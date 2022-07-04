using System;
using System.Windows.Forms;

using Model.Modules;

namespace PSW
{
    public partial class Resources : Form, IGameForm
    {
        private RegistrationModule _module;

        public Resources()
        {
            InitializeComponent();
            _module = null;
        }

        public void SetModule(IModule module)
        {
            if (_module != null)
                throw new Exception("Module already set");

            if (!(module is RegistrationModule rModule))
                throw new Exception("Module must be Registration Module");

            _module = rModule;
            _module.SubscribeOnFix(UpdateValues);
            _module.SubscribeOnCountUpdate(UpdateValues);
            UpdateValues();
        }

        private void UpdateValues()
        {
            // === main ===
            rarionsCount.Text = $"{_module.Rarions()} rs";
            deltasCount.Text = $"{_module.Deltas()} δs";
            huesCount.Text = $"{_module.Hues()} hs";
            hyperionsDensity.Text = $"{_module.HyperionsDensity()} H/m3";
            chiProbability.Text = $"{_module.Chi()} / {_module.Chi()*100}%";
            chiNeutralizer.Text = $"{_module.ChiNeutralizer()} g";
            chiCatalyst.Text = $"{_module.ChiCatalyst()} g";
            cameraValue.Text = $"{_module.CameraValue()} m3";
            criticalValue.Text = $"{_module.CriticalValue()}";

            // === side ===
            hyperionsCount.Text = $"{_module.Hyperions()} Hs";
            deltaDegree.Text = $"{_module.DeltaDegree()}";
            epsilonsCount.Text = $"{_module.Epsilons()} εs";
            huesActivity.Text = $"{_module.HuesActivity()}";
            huesResist.Text = $"{_module.HuesResist()} m3/h";
            huesProbability.Text = $"{_module.HuesProbability()} / {_module.HuesProbability() * 100}%";
            chideltaCorrelation.Text = $"{_module.ChiDeltaCorrelation()}";
            deltaSigma.Text = $"{_module.DeltaSigma()}";

            // === LKC ===
            (double edX, double edY) = _module.EpsilonDeltaDegree();
            epsilondeltaDegree.Text = $"({edX} ; {edY})";
            (double aR, double aF, double aS) = _module.AlphaDensity();
            alphaDensity.Text = $"[{aR}] + [~({aF}) * ({aS})]";
            chiCritical.Text = $"{_module.ChiCritical()}";
            chideltaCoherence.Text = $"{_module.ChiDeltaCorrelation()} + {_module.ChiSigma()} * {_module.DeltaSigma()}";
        }
    }
}
