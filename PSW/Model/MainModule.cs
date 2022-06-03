using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSW.Model
{
    public class MainModule : IModule
    {
        private LKCamera _camera;
        public MainModule(LKCamera camera)
        {
            _camera = camera;
        }

        public void FixCamera()
        {
            _camera.Fix();
        }
    }
}
