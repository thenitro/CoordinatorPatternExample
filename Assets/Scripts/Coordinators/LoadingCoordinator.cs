using System.Threading.Tasks;
using Controllers;
using Delegates;

namespace TymurKoshel.Coordinator.Sample
{
    public class LoadingCoordinator : AbstractCoordinator
    {
        private GameDelegate _delegate;
        
        protected override void OnPresent(IDelegate coordinatorDelegate = null)
        {
            _delegate = coordinatorDelegate as GameDelegate;
            ViewProvider.Instance.Preloader.SetActive(true);

            StartTimer();
        }

        protected override void OnDismiss()
        {
            ViewProvider.Instance.Preloader.SetActive(false);
        }

        private async void StartTimer()
        {
            await Task.Delay(2000);
            
            _delegate.OnLoad.Invoke();
        }
    }
}