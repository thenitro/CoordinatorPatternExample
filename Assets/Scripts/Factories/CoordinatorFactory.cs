using TymurKoshel.Coordinator;
using TymurKoshel.Coordinator.Sample;

namespace Factories
{
    public class CoordinatorFactory
    {
        public ICoordinator CreateGameplayCoordinator()
        {
            return new GameplayCoordinator();
        }

        public ICoordinator CreateLoadingCoordinator()
        {
            return new LoadingCoordinator();
        }

        public ICoordinator CreateMainScreenCoordinator()
        {
            return new MainScreenCoordinator();
        }
    }
}