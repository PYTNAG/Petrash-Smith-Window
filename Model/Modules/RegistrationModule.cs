using System;

using Model.Registrators;

namespace Model.Modules
{
    public class RegistrationModule : IModule
    {
        private readonly LKCamera _camera;

        private readonly Wire _vlampWire;
        private readonly Wire _zSieveWire;
        private readonly Wire _zjSieveWire;
        private readonly Wire _vFlask;
        private readonly Wire _pMetric;

        public RegistrationModule(LKCamera camera)
        {
            _camera = camera;

            _vlampWire = camera.AddRegistrator<VLamp>();
            _zSieveWire = camera.AddRegistrator<ZSieve>();
            _zjSieveWire = camera.AddRegistrator<ZJSieve>();
            _vFlask = camera.AddRegistrator<VFlask>();
            _pMetric = camera.AddRegistrator<PMetric>();
        }

        public void SubscribeOnFix(LKCamera.FixedEventHandler update)
        {
            _camera.OnFixed += update;
        }

        public void SubscribeOnCountUpdate(Hyperion.CountUpdate update)
        {
            _camera.SubscribeOnCountUpdate(update);
        }

        // TODO : Cash data
        public int Rarions() => BitConverter.ToInt32(_vlampWire.GetData(), 0);
        public int Deltas() => BitConverter.ToInt32(_zSieveWire.GetData(), 0);
        public int Hues() => BitConverter.ToInt32(_zjSieveWire.GetData(), 0);
        public double HyperionsDensity() => BitConverter.ToDouble(_vFlask.GetData(), 0);
        public double Chi() => BitConverter.ToDouble(_pMetric.GetData(), 0);
        public double CameraValue() => _camera.Value;
        public double CriticalValue() => _camera.CriticalNumber;
        public int Hyperions() => (int)Math.Round(HyperionsDensity() * CameraValue());
        public double DeltaDegree() => _camera.IsBroken ? -1 : Math.Round((double)Hyperions() / Deltas(), 3);
        public int Epsilons() => _camera.Get<Hyperions.Epsilons>().Count;
        public double ChiNeutralizer() => _camera.ChiNeutralizer;
        public double ChiCatalyst() => _camera.ChiCatalyst;
        public double HuesActivity()
        {
            if (_camera.IsBroken)
                return -1;

            return Math.Round((double)Hues() / (Hyperions() - Hues()), 4);
        }
        public double HuesResist() => _camera.IsBroken ? -1 : Math.Round(CameraValue() / Hues(), 3);
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

            double rMain = Deltas() * Chi() + Math.Pow(Chi(), Deltas()) / 2;
            double rSub = _camera.ChiNeutralizer * 1.57;

            return Math.Round(rMain + rSub, 3);
        }
        public double DeltaSigma() => _camera.IsBroken ? -1 : Math.Round(2.9 * Deltas() / CameraValue(), 4);

        public (double, double) EpsilonDeltaDegree()
        {
            if (_camera.IsBroken)
                return (-1, -1);

            double delta = (double)Deltas() / Hyperions();
            double x = delta * 2.0 * ((double)Deltas() / (Hyperions() - Deltas()));
            double y = x * Math.Sqrt(1 - delta * delta) / delta;

            return (Math.Round(x, 4), Math.Round(y, 4));
        }

        public (double, double, double) AlphaDensity()
        {
            if (_camera.IsBroken)
                return (-1, -1, -1);

            double aR = (double)(Epsilons() + Rarions()) / Hyperions();
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
                res += (i + 1) * Math.Pow(Chi(), (i % 3) + 1);
            }

            return Math.Round(res + _camera.ChiCatalyst, 4);
        }

        public double ChiSigma() => 3.5;
    }
}
