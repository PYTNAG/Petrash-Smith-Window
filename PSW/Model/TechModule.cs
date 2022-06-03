using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSW.Model
{
    public class TechModule : IModule
    {
        private LKCamera _camera;

        public TechModule(LKCamera camera)
        {
            _camera = camera;
        }
    }
}
