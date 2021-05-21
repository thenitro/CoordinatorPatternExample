using Delegates;
using UnityEngine;

namespace Views
{
    public class MainScreenView : MonoBehaviour
    {
        public MainScreenDelegate Delegate;

        public void OnPlay()
        {
            Delegate.OnPlay.Invoke();
        }
    }
}