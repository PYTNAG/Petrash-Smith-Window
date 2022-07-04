using System;

namespace Model.Registrators
{
    public class VFlask : IRegistrator
    {
        private double _density;
        private Wire _wire;

        public void LoadData(HyperSet set)
        {
            _density = set.Density();
        }

        private byte[] GetData() => BitConverter.GetBytes(_density);

        public Wire GetWire()
        {
            if (_wire == null)
                _wire = new Wire(GetData);

            return _wire;
        }
    }
}
