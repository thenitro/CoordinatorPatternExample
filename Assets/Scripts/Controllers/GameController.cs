using Controllers;
using TymurKoshel.Coordinator.Sample;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _preloader;
    [SerializeField] private GameObject _mainScreen;
    [SerializeField] private GameObject _gameplay;
    
    private void Start()
    {
        var provider = ViewProvider.Instance;
            provider.Preloader = _preloader;
            provider.MainScreen = _mainScreen;
            provider.Gameplay = _gameplay;

        var gameCoordinator = new GameCoordinator();
            gameCoordinator.Present(null);
    }
}
