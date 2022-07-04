namespace Model.Hyperions
{
    public class Epsilons : Hyperion
    {
        public override float? Diameter => 2.2f;

        public override float PositiveProbability => 0.98f;

        public override float ActiveProbability => 0.02f;

        public Epsilons(int count) : base(count) { }
    }
}
