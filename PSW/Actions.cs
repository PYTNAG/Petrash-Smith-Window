using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace PSW
{
    public partial class Actions : Form
    {
        private Player _player;

        private readonly Dictionary<Location, Button> _buttons;

        public Actions()
        {
            InitializeComponent();

            _buttons = new Dictionary<Location, Button>
            {
                { Model.Location.Home, Home },
                { Model.Location.RegistartionModule, RegistrationModule },
                { Model.Location.CheckModule, CheckModule },
                { Model.Location.TechModule, TechModule },
                { Model.Location.MainModule, MainModule }
            };

            SetButtonsEnable(false, Model.Location.Home);
        }

        public void SetPlayer(Player player)
        {
            _player = player;
            Time.Text = _player.CurrentTime.ToString("HH:mm");

            _player.OnTimeUpdated += (h, m) =>
            {
                Time.Text = $"{h:00}:{m:00}";

                if (_player.IsTimeToSleep())
                {
                    Time.Text += " Time to go home";

                    SetButtonsEnable(true, Model.Location.Home);
                }
            };

            _player.OnDayUpdated += (d) => Day.Text = $"День {_player.CurrentDay}";
        }

        private void SetButtonsEnable(bool value, params Location[] locations)
        {
            foreach (var pair in _buttons)
            {
                pair.Value.Enabled = locations.Contains(pair.Key) == value;
            }
        }

        private void MoveToHome(object sender, EventArgs e)
        {
            _player.Sleep();

            SetButtonsEnable(false, Model.Location.Home);
        }

        private void MoveToRegistrationModule(object sender, EventArgs e)
        {
            SetButtonsEnable(true, Model.Location.TechModule, Model.Location.Home);
            _player.Move(Model.Location.RegistartionModule, 20);
        }

        private void MoveToCheckModule(object sender, EventArgs e)
        {
            SetButtonsEnable(true, Model.Location.TechModule);
            _player.Move(Model.Location.CheckModule, 5);
        }

        private void MoveToTechModule(object sender, EventArgs e)
        {
            SetButtonsEnable(false, Model.Location.TechModule);
            _player.Move(Model.Location.TechModule, _player.CurrentLocation == Model.Location.RegistartionModule ? 20 : 5);
        }

        private void MoveToMainModule(object sender, EventArgs e)
        {
            SetButtonsEnable(true, Model.Location.TechModule);
            _player.Move(Model.Location.MainModule, 5);
        }
    }
}
