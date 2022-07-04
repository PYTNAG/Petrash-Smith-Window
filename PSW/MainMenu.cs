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
using Model.Modules;

namespace PSW
{
    public partial class MainMenu : Form
    {
        private readonly LKCamera _camera;
        private readonly Dictionary<Location, Form> _forms;

        private readonly Player _player;

        public MainMenu()
        {
            InitializeComponent();

            _camera = new LKCamera();
            _forms = new Dictionary<Location, Form>();

            _player = new Player();
            _player.OnMove += LocationUpdated;
            _player.OnEnd += End;
        }

        private void End(Result r)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            LoadWindows();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            LoadCamera();
            LoadWindows();
        }

        private void LoadWindows()
        {
            Visible = false;
            LoadGameWindow<Resources>(Model.Location.RegistartionModule, new RegistrationModule(_camera));
            LoadGameWindow<Tech>(Model.Location.TechModule, new TechModule(_camera));
            LoadGameWindow<Camera>(Model.Location.MainModule, new MainModule(_camera));

            Actions actions = new Actions();
            actions.FormClosed += (sender, e) => Close();
            actions.SetPlayer(_player);
            actions.Show();
        }

        private void LocationUpdated(Location from, Location to)
        {
            if (_forms.TryGetValue(from, out Form fromForm))
                fromForm.Hide();

            if (_forms.TryGetValue(to, out Form toForm))
                toForm.Show();
        }

        private void LoadCamera()
        {

        }

        private void LoadGameWindow<T>(Location location, IModule module) where T : Form, IGameForm, new()
        {
            T gameWindow = new T();
            gameWindow.SetModule(module);
            gameWindow.FormClosed += (sender, e) => Close();

            _forms.Add(location, gameWindow);
        }
    }
}
