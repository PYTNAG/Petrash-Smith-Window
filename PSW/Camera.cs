using PSW.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
