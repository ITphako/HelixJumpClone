
using Zenject;
using UnityEngine;

public class ServicesInstaller : MonoInstaller
{
    
        [SerializeField] private GameMode _gameMode;
        [SerializeField] private TowerBuilder _towerBuilder;

        private GameEvents _gameEvents;
        private CurrencyVault _currencyVault;
       [SerializeField] private InputTouch _inputTouch;
        [SerializeField] private GameScreens _gameScreens;

         public override void InstallBindings()
        {
            _gameEvents = new GameEvents();
            _currencyVault = new CurrencyVault();

            GameMode();

            GameEventsExecuter();
            GameEventsListener();

            CurrencyVault();
            TowerBuilder();
            InputTouch();
            GameScreens();
        }

         private void GameMode()
        {
            Container
                .Bind<GameMode>()
                .To<GameMode>()
                .FromInstance(_gameMode)
                .AsSingle()
                .NonLazy();
        }

        private void GameEventsExecuter()
        {
              Container
                .Bind<IGameEventsExecuter>()
                .To<GameEvents>()
                .FromInstance(_gameEvents)
                .NonLazy();
        }

        private void GameEventsListener()
        {
            Container
                .Bind<IGameEventsListener>()
                .To<GameEvents>()
                .FromInstance(_gameEvents)
                .NonLazy();
        }

         private void CurrencyVault()
            {
            Container
                .Bind<ICurrencyVault>()
                .To<CurrencyVault>()
                .FromInstance(_currencyVault)
                .NonLazy();

            Container
                .Bind<ICurrencyVaultState>()
                .To<CurrencyVault>()
                .FromInstance(_currencyVault)
                .NonLazy();
            }

            private void TowerBuilder()
            {
                  Container
                .Bind<ITowerBuilder>()
                .To<TowerBuilder>()
                .FromInstance(_towerBuilder)
                .NonLazy();
            }

            private void InputTouch()
            {
                  Container
                .Bind<IInputTouch>()
                .To<InputTouch>()
                .FromInstance(_inputTouch)
                .NonLazy();
            }

     private void GameScreens()
        {
            Container
                .Bind<GameScreens>()
                .To<GameScreens>()
                .FromInstance(_gameScreens)
                .AsSingle()
                .NonLazy();
        }
    }

