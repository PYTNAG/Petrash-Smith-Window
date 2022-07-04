namespace Model.Hyperions
{
    public class Zetas : Hyperion
    {
        public override float? Diameter => 4.1f;

        public override float PositiveProbability => 0.347f;

        public override float ActiveProbability => 0.121f;

        public Zetas(int count) : base(count) { }
    }
}
