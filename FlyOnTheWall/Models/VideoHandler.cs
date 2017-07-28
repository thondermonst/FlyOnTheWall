namespace FlyOnTheWall.Models
{
    internal class VideoHandler : ModelBase
    {
        private static VideoHandler _instance;

        private VideoHandler()
        {

        }

        public static VideoHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VideoHandler();
                }
                return _instance;
            }
        }
    }
}
