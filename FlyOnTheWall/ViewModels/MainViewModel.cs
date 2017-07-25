namespace FlyOnTheWall.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        private static MainViewModel _instance;

        private MainViewModel()
        {

        }

        public static MainViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainViewModel();
                }
                return _instance;
            }
        }
    }
}
