using System;
using System.Windows.Forms;

using Model.Modules;

namespace PSW
{
    public partial class Camera : Form, IGameForm
    {
        private MainModule _module;

        public Camera()
        {
            InitializeComponent();
        }

        public void SetModule(IModule module)
        {
            if (!(module is MainModule mModule))
                throw new Exception("This is not a MainModule");

            if (_module != null)
                throw new Exception("Module already set");

            _module = mModule;
        }

        private void FixCamera(object sender, EventArgs e)
        {
            _module.FixCamera();
        }
    }
}
