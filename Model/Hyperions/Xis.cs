namespace Model.Hyperions
{
    public class Xis : Hyperion
    {
        public override float? Diameter => 2.41f;

        public override float PositiveProbability => 0.347f;

        public override float ActiveProbability => 0.121f;

        public Xis(int count) : base(count) { }
    }
}
