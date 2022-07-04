using System.Collections.Generic;

using Model.Registrators;

namespace Model
{
    public class LKCamera
    {
        public delegate void FixedEventHandler();
        public event FixedEventHandler OnFixed;

        public bool IsBroken { get; private set; }

        private readonly HashSet<IRegistrator> _registrators;

        private readonly HyperSet _hyperions;

        private double _chiNeutralizer;
        public double ChiNeutralizer { get => IsBroken ? 0 : _chiNeutralizer; set => _chiNeutralizer = value;}

        private double _chiCatalyst;
        public double ChiCatalyst { get => IsBroken ? 0 : _chiCatalyst; set => _chiCatalyst = value;}

        public double Value { get; }
        public double CriticalNumber { get; }

        public LKCamera()
        {
            Value = 10;
            CriticalNumber = 13;

            _hyperions = new HyperSet(Value);
            _registrators = new HashSet<IRegistrator>();
        }

        public Wire AddRegistrator<T>() where T : IRegistrator, new()
        {
            T r = new T();
            r.LoadData(IsBroken ? HyperSet.WorldHyperSet : _hyperions);
            _registrators.Add(r);
            return r.GetWire();
        }

        public Wire GetWireFor<T>() where T : IRegistrator
        {
            foreach (var registrator in _registrators)
            {
                if (registrator is T)
                {
                    return registrator.GetWire();
                }
            }

            return null;
        }

        public T Get<T>() where T : Hyperion
        {
            return IsBroken ? HyperSet.WorldHyperSet.Get<T>() : _hyperions.Get<T>();
        }

        public void Fix()
        {
            if (!IsBroken)
                return;

            IsBroken = false;
            OnFixed?.Invoke();

            foreach (var registrator in _registrators)
            {
                registrator.LoadData(_hyperions);
            }
        }

        public void SubscribeOnCountUpdate(Hyperion.CountUpdate update)
        {
            _hyperions.SubscribeOnCountUpdate(update);
        }
    }
}
