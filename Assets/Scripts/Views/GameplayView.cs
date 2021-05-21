using Delegates;
using UnityEngine;

namespace Views
{
    public class GameplayView : MonoBehaviour
    {
        public GameplayDelegate Delegate;

        public void OnExit()
        {
            Delegate.OnExit.Invoke();
        }
    }
}