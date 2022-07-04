namespace Model.Hyperions
{
    public class Rarions : Hyperion
    {
        public override float? Diameter => 1.63f;

        public override float PositiveProbability => 0.071f;

        public override float ActiveProbability => 0.41f;

        public Rarions(int count) : base(count) { }
    }
}
