
using UnityEngine.SceneManagement;
using Zenject;
using UnityEngine;

public class LevelRewards : MonoBehaviour
{
   private IGameEventsListener _gameEventsListener;
        private GameScreens _gameScreens;
        private PlayerProgress _playerProgress;

        [Inject]
        private void Construction(IGameEventsListener gameEventsListener, GameScreens gameScreens, PlayerProgress playerProgress)
        {
            _gameEventsListener = gameEventsListener;
            _gameScreens = gameScreens;
            _playerProgress = playerProgress;
    }
    
    public void LevelWin()
        {
            _playerProgress.ProgressData.UnlockLevel(SceneManager.GetActiveScene().buildIndex + 1);
            _playerProgress.Save();

            _gameScreens.ShowWinScreen();
        }

}
