namespace Model.Hyperions
{
    public class Taus : Hyperion
    {
        public override float? Diameter => 1.09f;

        public override float PositiveProbability => 0.121f;

        public override float ActiveProbability => 0.121f;

        public Taus(int count) : base(count) { }
    }
}
