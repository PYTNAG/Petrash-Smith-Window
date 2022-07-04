namespace Model.Hyperions
{
    public class Deltas : Hyperion
    {
        public override float? Diameter => 3.59f;

        public override float PositiveProbability => 0.31f;

        public override float ActiveProbability => 0.41f;

        public Deltas(int count) : base(count) { }
    }
}
