using System;

namespace PSW.Model
{
    public class LKCamera
    {
        public delegate void FixedEventHandler();
        public event FixedEventHandler OnUpdated;

        private bool _isBroken;
        public bool IsBroken => _isBroken;

        public int Rarions { get; }
        public int Deltas { get; }
        public int Hues { get; }
        public double Chi { get; }
        public int Epsilons { get; }
        public int Others { get; }
        public int HyperionsCount => Rarions + Deltas + Hues + 1 + Epsilons + Others;

        public double? HyperionsDensity => HyperionsCount / Value;

        public double ChiNeutralizer { get; }
        public double ChiCatalyst { get; }

        public double Value { get; }
        public double CriticalNumber { get; }

        public LKCamera()
        {
            _isBroken = true;

            //all = 70
            Rarions = 7;
            Deltas = 30;//
            Hues = 5;
            Chi = 0.06;//1
            Epsilons = 20;//
            Others = 7;

            if (Epsilons != (HyperionsCount - Deltas) / 2)
                throw new Exception("Wrong configuration");

            ChiNeutralizer = 0;
            ChiCatalyst = 0;

            Value = 10;
            CriticalNumber = 13;
        }

        public void Fix()
        {
            _isBroken = false;
            OnUpdated.Invoke();
        }
    }
}
