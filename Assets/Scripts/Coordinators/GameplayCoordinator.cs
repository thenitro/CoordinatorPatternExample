using Controllers;
using Delegates;
using Views;

namespace TymurKoshel.Coordinator.Sample
{
    public class GameplayCoordinator : AbstractCoordinator
    {
        private GameplayDelegate _delegate = new GameplayDelegate();
        private GameDelegate _parentDelegate;
        public override IDelegate Delegate { get => _delegate; }

        protected override void OnPresent(IDelegate coordinatorDelegate = null)
        {
            _parentDelegate = coordinatorDelegate as GameDelegate;

            _delegate.OnExit += OnExit;

            var go = ViewProvider.Instance.Gameplay;
                go.SetActive(true);
                go.GetComponent<GameplayView>().Delegate = _delegate;
        }

        protected override void OnDismiss()
        {
            ViewProvider.Instance.Gameplay.SetActive(false);
        }

        private void OnExit()
        {
            _parentDelegate.OnStopGameplay.Invoke();
        }
    }
}