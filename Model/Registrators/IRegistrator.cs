namespace Model.Registrators
{
    public interface IRegistrator
    {
        void LoadData(HyperSet set);

        Wire GetWire();
    }
}
