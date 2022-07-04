namespace Model
{
    public abstract class Hyperion
    {
        public delegate void CountUpdate();
        public event CountUpdate OnCountUpdate;

        public abstract float? Diameter { get; }
        public abstract float PositiveProbability { get; }
        public abstract float ActiveProbability { get; }
        public float FictiveProbability => 1 / (PositiveProbability * ActiveProbability);

        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                if (value < 0)
                    value = 0;

                _count = value;
                OnCountUpdate?.Invoke();
            }
        }

        public Hyperion(int count)
        {
            _count = count;
        }
    }
}
