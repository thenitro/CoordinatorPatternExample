using Delegates;
using Factories;

namespace TymurKoshel.Coordinator.Sample
{
    //Part 5
    /*public class GameCoordinator : ICoordinator
    {
        private ICoordinator _loadingCoordinator;
        private ICoordinator _mainScreenCoordinator;
        private ICoordinator _gameplayCoordinator;

        public IDelegate Delegate { get => _delegate; }

        private GameDelegate _delegate = new GameDelegate();
        private IRouter _router = new Router();
        private CoordinatorFactory _factory = new CoordinatorFactory();

        public void Present(IDelegate parentDelegate = null)
        {
            //TODO: create view and do some preparation
            
            _delegate.OnLoad += OnLoad;
            _delegate.OnStartGameplay += OnStartGameplay;
            _delegate.OnStopGameplay += OnStopGameplay;
            
            StartLoading();
        }

        public void Dismiss()
        {
            //TODO: destroy view and do some cleaning
            
            _delegate.OnLoad -= OnLoad;
            _delegate.OnStartGameplay -= OnStartGameplay;
            _delegate.OnStopGameplay -= OnStopGameplay;

            _loadingCoordinator = null;
            _mainScreenCoordinator = null;
            _gameplayCoordinator = null;
        }

        private void StartLoading()
        {
            _loadingCoordinator = _factory.CreateLoadingCoordinator();
            _router.Transition(this, null, _loadingCoordinator);
        }

        private void OnLoad()
        {
            _mainScreenCoordinator = _factory.CreateMainScreenCoordinator();
            _router.Transition(this, _loadingCoordinator, _mainScreenCoordinator);
            _loadingCoordinator = null;
        }

        private void OnStartGameplay()
        {
            _gameplayCoordinator = _factory.CreateGameplayCoordinator();
            _router.Transition(this, _mainScreenCoordinator, new GameplayCoordinator());
            _mainScreenCoordinator = null;
        }

        private void OnStopGameplay()
        {
            _mainScreenCoordinator = _factory.CreateMainScreenCoordinator();
            _router.Transition(this, _gameplayCoordinator, _mainScreenCoordinator);
            _gameplayCoordinator = null;
        }
    }*/
    
    //final
    public class GameCoordinator : AbstractCoordinator
    {
        private ICoordinator _loadingCoordinator;
        private ICoordinator _mainScreenCoordinator;
        private ICoordinator _gameplayCoordinator;

        public override IDelegate Delegate { get => _delegate; }

        private GameDelegate _delegate = new GameDelegate();
        private IRouter _router = new Router();
        private CoordinatorFactory _factory = new CoordinatorFactory();

        protected override void OnPresent(IDelegate coordinatorDelegate = null)
        {
            //TODO: create view and do some preparation
            
            _delegate.OnLoad += OnLoad;
            _delegate.OnStartGameplay += OnStartGameplay;
            _delegate.OnStopGameplay += OnStopGameplay;
            
            StartLoading();
        }

        protected override void OnDismiss()
        {
            //TODO: destroy view and do some cleaning
            
            _delegate.OnLoad -= OnLoad;
            _delegate.OnStartGameplay -= OnStartGameplay;
            _delegate.OnStopGameplay -= OnStopGameplay;

            _loadingCoordinator = null;
            _mainScreenCoordinator = null;
            _gameplayCoordinator = null;
        }

        private void StartLoading()
        {
            _loadingCoordinator = _factory.CreateLoadingCoordinator();
            _router.Transition(this, null, _loadingCoordinator);
        }

        private void OnLoad()
        {
            _mainScreenCoordinator = _factory.CreateMainScreenCoordinator();
            _router.Transition(this, _loadingCoordinator, _mainScreenCoordinator);
            _loadingCoordinator = null;
        }

        private void OnStartGameplay()
        {
            _gameplayCoordinator = _factory.CreateGameplayCoordinator();
            _router.Transition(this, _mainScreenCoordinator, new GameplayCoordinator());
            _mainScreenCoordinator = null;
        }

        private void OnStopGameplay()
        {
            _mainScreenCoordinator = _factory.CreateMainScreenCoordinator();
            _router.Transition(this, _gameplayCoordinator, _mainScreenCoordinator);
            _gameplayCoordinator = null;
        }
    }
}