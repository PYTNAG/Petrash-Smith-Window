using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using PSW.Model;

namespace PSW
{
    public partial class Tech : Form, IGameForm
    {
        private TechModule _module;

        public Tech()
        {
            InitializeComponent();
            PauseReserves();
        }

        public void SetModule(IModule module)
        {
            if (_module != null)
                throw new Exception("Module already set");

            if (!(module is TechModule tModule))
                throw new Exception("Module must be Main");

            _module = tModule;
        }

        private void PauseReserves()
        {
            PauseProgressBar(deltaBottleReserve);
            PauseProgressBar(Gazer12Reserve);
            PauseProgressBar(PZReserve);
            PauseProgressBar(ChiStopReserve);
            PauseProgressBar(ChiCatalystReserve);
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
    }
}
