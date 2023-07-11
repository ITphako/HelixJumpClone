using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Zenject;

public class LevelStateMachine
    {
        private Dictionary<Type, ILevelState> _states;
        private ILevelState _currentState;

        public LevelStateMachine( DiContainer diContainer,GameMode gameMode)
        {
            _states = new Dictionary<Type, ILevelState>
            {
                [typeof(LoadLevelState)] = new LoadLevelState(this, diContainer),
                [typeof(LoadLevelProgressState)] = new LoadLevelProgressState(this),
                [typeof(InitializeLevelState)] = new InitializeLevelState(this, diContainer, gameMode),
                [typeof(LevelLoopState)] = new LevelLoopState(this, diContainer),
                [typeof(LevelDestroyState)] = new LevelDestroyState()
            };
        }

        public void Enter<TLevelState>() where TLevelState : ILevelState
        {
            if (_currentState != null)
                _currentState?.Exit();

            ILevelState state = _states[typeof(TLevelState)];

            _currentState = state;
            state.Enter();
        }
    }
