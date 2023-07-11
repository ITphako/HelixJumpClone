
using UnityEngine.SceneManagement;
using UnityEngine;
using Zenject;

public class LevelInstance : MonoBehaviour
{
        private LevelStateMachine _levelStateMachine;

        private DiContainer _diContainer;
        private IGameEventsExecuter _gameEventsExecuter;
        private GameInstance _gameInstance;
        private GameMode _gameMode;


        [Inject]
        private void Construct(DiContainer diContainer, IGameEventsExecuter gameEventsExecuter,GameInstance gameInstance,GameMode gameMode)
        {
            _diContainer = diContainer;
            _gameEventsExecuter = gameEventsExecuter;
            _gameInstance = gameInstance;
            _gameMode = gameMode;

        }


        private void Awake()
        {
            _gameEventsExecuter.OnLevelBootstrap();

            _levelStateMachine = new LevelStateMachine( _diContainer, _gameMode);

            _levelStateMachine.Enter<LoadLevelState>();
        }
        
         public void GoMenu()
        {
            SceneManager.LoadScene(GameConstants.MAIN_MENU_SCENE_INDEX);
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void NextLevel()
        {
            ProgressData data = _gameInstance.Progress.ProgressData;

            int nextSceneID = SceneManager.GetActiveScene().buildIndex + 1;

            foreach(var item in data.Levels)
            {
                if(item.LevelID == nextSceneID)
                {
                    SceneManager.LoadScene(nextSceneID);
                    return;
                }
            }

            SceneManager.LoadScene(GameConstants.MAIN_MENU_SCENE_INDEX);

        }

        private void OnDestroy()
        {
            _levelStateMachine.Enter<LevelDestroyState>();
        }
    
}
