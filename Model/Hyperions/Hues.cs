namespace Model.Hyperions
{
    public class Hues : Hyperion
    {
        public override float? Diameter => null;
        public override float PositiveProbability => 1;
        public override float ActiveProbability => 1;

        public Hues(int count) : base(count) { }
    }
}
