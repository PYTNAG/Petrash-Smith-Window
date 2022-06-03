using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSW.Model
{
    public class RegistrationModule : IModule
    {
        private LKCamera _camera;

        public RegistrationModule(LKCamera camera)
        {
            _camera = camera;
        }

        public void SubscribeOnUpdate(LKCamera.FixedEventHandler update)
        {
            _camera.OnUpdated += update;
        }

        public int Rarions() => _camera.IsBroken ? -1 : _camera.Rarions;
        public int Deltas() => _camera.IsBroken ? -1 : _camera.Deltas;
        public int Hues() => _camera.IsBroken ? -1 : _camera.Hues;
        public double HyperionsDensity() => _camera.IsBroken ? -1 : Math.Round(_camera.HyperionsCount / _camera.Value, 3);
        public double Chi() => _camera.IsBroken ? -1 : _camera.Chi;
        public double ChiNeutralizer() => _camera.IsBroken ? -1 : _camera.ChiNeutralizer;
        public double ChiCatalyst() => _camera.IsBroken ? -1 : _camera.ChiCatalyst;
        public double CameraValue() => _camera.IsBroken ? -1 : _camera.Value;
        public double CriticalValue() => _camera.IsBroken ? -1 : _camera.CriticalNumber;
        public int Hyperions() => _camera.IsBroken ? -1 : _camera.HyperionsCount;
        public double DeltaDegree() => _camera.IsBroken ? -1 : Math.Round((double)_camera.HyperionsCount / _camera.Deltas, 3);
        public int Epsilons() => _camera.IsBroken ? -1 : _camera.Epsilons;
        public double HuesActivity()
        {
            if (_camera.IsBroken)
                return -1;

            return Math.Round((double)_camera.Hues / (_camera.HyperionsCount - _camera.Hues), 4);
        }
        public double HuesResist() => _camera.IsBroken ? -1 : Math.Round(_camera.Value / _camera.Hues, 3);
        public double HuesProbability()
        {
            if (_camera.IsBroken)
                return -1;

            return Math.Round(Math.Pow(HuesActivity(), 2) * HuesResist(), 4);
        }
        public double ChiDeltaCorrelation()
        {
            if (_camera.IsBroken)
                return -1;

            double rMain = _camera.Deltas * _camera.Chi + Math.Pow(_camera.Chi, _camera.Deltas) / 2;
            double rSub = _camera.ChiNeutralizer * 1.57;

            return Math.Round(rMain + rSub, 3);
        }
        public double DeltaSigma() => _camera.IsBroken ? -1 : Math.Round(2.9 * _camera.Deltas / _camera.Value, 4);

        public (double, double) EpsilonDeltaDegree()
        {
            if (_camera.IsBroken)
                return (-1, -1);

            double delta = (double)_camera.Deltas / _camera.HyperionsCount;
            double x = delta * 2.0 * ((double)_camera.Deltas / (_camera.HyperionsCount - _camera.Deltas));
            double y = x * Math.Sqrt(1 - delta * delta) / delta;

            return (Math.Round(x, 4), Math.Round(y, 4));
        }

        public (double, double, double) AlphaDensity()
        {
            if (_camera.IsBroken)
                return (-1, -1, -1);

            double aR = (double)(_camera.Epsilons + _camera.Rarions) / _camera.HyperionsCount;
            double Ph = HuesProbability();
            double aS = Ph / (1 + Ph);
            double aF = Math.PI * aS;

            return (Math.Round(aR, 4), Math.Round(aF, 4), Math.Round(aS, 4));
        }

        public double ChiCritical()
        {
            if (_camera.IsBroken)
                return -1;

            double res = 0;
            for (int i = 0; i <= _camera.CriticalNumber; ++i)
            {
                res += (i + 1) * Math.Pow(_camera.Chi, (i % 3) + 1);
            }

            return Math.Round(res + _camera.ChiCatalyst, 4);
        }

        public double ChiSigma() => 3.5;
    }
}
