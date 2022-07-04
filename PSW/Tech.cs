using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Model.Modules;

namespace PSW
{
    public partial class Tech : Form, IGameForm
    {
        private TechModule _module;

        private readonly HashSet<GroupBox> _groupBoxes;

        private readonly HashSet<Container<float>> _checkedContainers;
        private readonly Dictionary<GroupBox, Container<float>> _containersMap;

        public Tech()
        {
            InitializeComponent();

            _groupBoxes = new HashSet<GroupBox>
            {
                DeltaBottle,
                Gazer12,
                PZ,
                ChiStop,
                ChiCatalyst
            };

            _checkedContainers = new HashSet<Container<float>>();
            _containersMap = new Dictionary<GroupBox, Container<float>>();
        }

        public void SetModule(IModule module)
        {
            if (_module != null)
                throw new Exception("Module already set");

            if (!(module is TechModule tModule))
                throw new Exception("Module must be Tech");

            _module = tModule;

            _containersMap.Add(DeltaBottle, _module.DeltaBottle);
            _containersMap.Add(Gazer12, _module.Gazer12);
            _containersMap.Add(PZ, _module.PZ);
            _containersMap.Add(ChiStop, _module.ChiStop);
            _containersMap.Add(ChiCatalyst, _module.ChiCatalyst);

            Config();
        }

        private void Config()
        {
            foreach (var gb in _groupBoxes)
            {
                ConfigGroupBox(gb);
            }

            PauseReserves();
        }

        private void ConfigGroupBox(GroupBox gb)
        {
            Container<float> container = _containersMap[gb];

            UpdateGroupBoxName(gb, container.LeftCount);

            gb.Get<Button>().Click += (sender, e) => container.Replace();

            container.OnLeftCountChanged += (v) => UpdateGroupBoxName(gb, v);

            container.OnSwitch += (v) =>
            {
                gb.Get<Button>().Enabled = !v;
            };

            container.OnValueChanged += (newV, outV) =>
            {
                var reserve = gb.Get<ProgressBar>();
                int outPercent = 5;

                if (outV == 0)
                    outPercent = 0;

                reserve.Value -= outPercent;
            };

            gb.Get<CheckBox>().CheckedChanged += (sender, e) =>
            {
                if (((CheckBox)sender).Checked)
                    _checkedContainers.Add(container);
                else
                    _checkedContainers.Remove(container);
            };
        }

        private static void UpdateGroupBoxName(GroupBox gb, int leftCount)
        {
            string[] nameWords = gb.Text.Split(' ');
            nameWords.SetValue(leftCount.ToString(), nameWords.Length - 1);
            gb.Text = string.Join(" ", nameWords);
        }

        private void PauseReserves()
        {
            foreach (var box in _groupBoxes)
            {
                PauseProgressBar(box.Get<ProgressBar>());
            }
        }

        private void PauseProgressBar(ProgressBar pb)
        {
            SendMessage(pb.Handle,
                0x400 + 16,
                0x0003, // PAUSE
                0);
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern uint SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        private void OpenCloseBtn_Click(object sender, EventArgs e)
        {
            foreach (var c in _checkedContainers)
            {
                c.Switch();
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            _module.Load();
        }
    }

    public static class GroupBoxExtensions
    {
        public static T Get<T>(this GroupBox gb) where T : class
        {
            var e = gb.Controls.GetEnumerator();
            while (e.MoveNext())
            {
                if (e.Current is T t)
                    return t;
            }

            return null;
        }
    }
}
