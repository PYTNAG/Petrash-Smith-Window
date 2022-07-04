namespace Model.Modules
{
    public class MainModule : IModule
    {
        private LKCamera _camera;

        public MainModule(LKCamera camera)
        {
            _camera = camera;
        }

        public void FixCamera()
        {
            _camera.Fix();
        }
    }
}
