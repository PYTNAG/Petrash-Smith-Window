namespace Model.Hyperions
{
    public class Chi : Hyperion
    {
        public override float? Diameter => 1f;

        public override float PositiveProbability => 0.97f;

        public override float ActiveProbability => 0.02f;

        public Chi() : base(1) { }
    }
}
