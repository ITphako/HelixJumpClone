
using System;

 public interface IGameEventsListener
    {
         event Action LevelLoaded;
        event Action LevelInitialized;
        event Action LevelLoopEnter;

        event Action LevelReady;
        event Action LevelEnd;

        event Action LevelBootstrap;
        event Action ActorCollision;
        event Action<Actor, Actor> ActorCollisionActor;
        event Action<Actor> ActorSpawned;
        event Action<Actor, Actor> ActorCollisionExitActor;
        event Action<Actor> ActorDied;
        event Action<Actor> ActorLeftGround;
        event Action LevelWin;
        event Action LevelLose;
    }
