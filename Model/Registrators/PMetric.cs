using System;

using Model.Hyperions;

namespace Model.Registrators
{
    public class PMetric : IRegistrator
    {
        private double _probability;
        private Wire _wire;

        public void LoadData(HyperSet set)
        {
            Chi x = set.Get<Chi>();
            _probability = x.ActiveProbability * x.PositiveProbability;
        }

        private byte[] GetData() => BitConverter.GetBytes(_probability);

        public Wire GetWire()
        {
            if (_wire == null)
                _wire = new Wire(GetData);

            return _wire;
        }
    }
}
