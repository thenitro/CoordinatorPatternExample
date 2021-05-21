using UnityEngine;

namespace Controllers
{
    public class ViewProvider
    {
        private static ViewProvider _instance;
        public static ViewProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ViewProvider();
                }

                return _instance;
            }
        }

        public GameObject Preloader;
        public GameObject MainScreen;
        public GameObject Gameplay;
    }
}