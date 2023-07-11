using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Zenject;

public class MatchThreeGameMode : GameMode
{
    private IGameEventsListener _gameEventsListener;
    private IGameEventsExecuter _gameEventsExecuter;
        private ICurrencyVault _currencyVault;

     [Inject]
        private void Construct(IGameEventsListener gameEventsListener, IGameEventsExecuter gameEventsExecuter,
            ICurrencyVault currencyVault)
        {
            _gameEventsListener = gameEventsListener;
            _gameEventsExecuter = gameEventsExecuter;
            _currencyVault = currencyVault;
        }

         public override void ConstructMethod()
        {
        }
}
