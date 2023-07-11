using System.Collections;
using UnityEngine;

public abstract class GameMode : MonoBehaviour
    {
        public string MapName => _mapName;

        [SerializeField] private string _mapName;

        public virtual void ConstructMethod()
        {

        }

        public virtual void BeginPlay()
        {

        }

        public void SetMapName(string mapName)
        {
            _mapName = mapName;
        }
    }