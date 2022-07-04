using System.Collections.Generic;

using Model.Hyperions;

namespace Model.Modules
{
    public class TechModule : IModule
    {
        private readonly LKCamera _camera;

        public Container<float> DeltaBottle { get; }
        public Container<float> Gazer12 { get; }
        public Container<float> PZ { get; }
        public Container<float> ChiStop { get; }
        public Container<float> ChiCatalyst { get; }

        private readonly HashSet<Container<float>> _containers;

        public TechModule(LKCamera camera)
        {
            _camera = camera;

            DeltaBottle = new Container<float>(100, v => _camera.Get<Deltas>().Count += v);
            Gazer12 = new Container<float>(100, v => _camera.Get<Hues>().Count += v);
            PZ = new Container<float>(100, v => _camera.Get<Rarions>().Count += v);
            ChiStop = new Container<float>(100, v => _camera.ChiNeutralizer += v);
            ChiCatalyst = new Container<float>(100, v => _camera.ChiCatalyst += v);

            _containers = new HashSet<Container<float>>
            {
                DeltaBottle,
                Gazer12,
                PZ,
                ChiStop,
                ChiCatalyst
            };
        }

        public void Load()
        {
            foreach (var container in _containers)
            {
                if (container.IsOpened)
                {
                    container.OpenFor20Minutes();
                }
            }
        }
    }

    public class Container<T>
    {
        public delegate void SwitchEvent(bool newValue);
        public event SwitchEvent OnSwitch;

        public delegate void LeftCountChanged(int newValue);
        public event LeftCountChanged OnLeftCountChanged;

        public delegate void ValueChanged(float newValue, float outValue);
        public event ValueChanged OnValueChanged;

        public delegate void AddFunc(int value);
        private readonly AddFunc _add;

        public bool IsOpened { get; private set; }

        private int _leftCount;
        public int LeftCount
        {
            get => _leftCount;
            private set
            {
                _leftCount = value;
                OnLeftCountChanged?.Invoke(_leftCount);
            }
        }

        private float _currentValue;
        private readonly float _maxValue;

        public Container(float maxValue, AddFunc add)
        {
            _add = add;

            IsOpened = false;
            LeftCount = 0;

            _currentValue = maxValue;
            _maxValue = maxValue;
        }

        public float OpenFor20Minutes()
        {
            int outPercent = 5;
            float outValue = _maxValue * (float)outPercent / 100; // 5% of maxValue for 20 min

            if (_currentValue < outValue)
            {
                outValue = _currentValue;
            }

            _currentValue -= outValue;
            OnValueChanged?.Invoke(_currentValue, outValue);

            // 1% == 1 hyperion
            _add(outPercent);

            return outValue;
        }

        public void Switch()
        {
            IsOpened = !IsOpened;
            OnSwitch.Invoke(IsOpened);
        }

        public bool Replace()
        {
            if (LeftCount > 0 && !IsOpened)
            {
                _currentValue = _maxValue;
                LeftCount--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
