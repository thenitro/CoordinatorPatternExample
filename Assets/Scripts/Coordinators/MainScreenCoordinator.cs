using Controllers;
using Delegates;
using Views;

namespace TymurKoshel.Coordinator.Sample
{
    public class MainScreenCoordinator : AbstractCoordinator
    {
        private MainScreenDelegate _delegate = new MainScreenDelegate();
        private GameDelegate _parentDelegate;
        
        protected override void OnPresent(IDelegate coordinatorDelegate = null)
        {
            _parentDelegate = coordinatorDelegate as GameDelegate;
            _delegate.OnPlay += OnPlay;
            
            var go = ViewProvider.Instance.MainScreen;
                go.SetActive(true);
                go.GetComponent<MainScreenView>().Delegate = _delegate;
        }

        protected override void OnDismiss()
        {
            ViewProvider.Instance.MainScreen.SetActive(false);
        }

        private void OnPlay()
        {
            _parentDelegate.OnStartGameplay.Invoke();
        }
    }
}