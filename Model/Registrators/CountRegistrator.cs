using System;

namespace Model.Registrators
{
    public class CountRegistrator<T> : IRegistrator where T : Hyperion
    {
        protected T _hyperions;
        protected Wire _wire;

        public virtual void LoadData(HyperSet set)
        {
            _hyperions = set.Get<T>();
        }

        private byte[] GetData() => BitConverter.GetBytes(_hyperions.Count);

        public virtual Wire GetWire()
        {
            if (_wire == null)
                _wire = new Wire(GetData);

            return _wire;
        }
    }
}
