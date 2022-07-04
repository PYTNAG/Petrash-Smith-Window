namespace Model
{
    public class Wire
    {
        public delegate byte[] GetDataFunc();

        private GetDataFunc _getData;

        public Wire(GetDataFunc getDataFunc)
        {
            _getData = getDataFunc;
        }

        public byte[] GetData() => _getData?.Invoke();
    }
}
