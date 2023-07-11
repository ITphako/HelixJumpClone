using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnerPlatform : MonoBehaviour
{
    [SerializeField] private GameObject _deam;
    [SerializeField] private float _additionalScale;
    [SerializeField] private SpawnPlatform _spawnPlatform;
    [SerializeField] private Platform[] _platform;
    [SerializeField] private FinishPlatform _finishPlatform;

     private ITowerBuilder _towerBuilder;
     private IGameEventsExecuter _gameEventsExecuter;

   [Inject]
        private void Construct(ITowerBuilder towerBuilder,IGameEventsExecuter gameEventsExecuter)
        {
            _towerBuilder = towerBuilder;
            _gameEventsExecuter = gameEventsExecuter;
        }

    private void Awake()
    {
        Build();
    }

    private void Build()
    {  
        _towerBuilder.SetBeam(_deam);
        _deam = Instantiate(_deam, transform);
        _deam.transform.localScale = new Vector3(1, _towerBuilder.GetBeamScale(), 1);

      Vector3 spawnPosition = _deam.transform.position;
        spawnPosition.y += _deam.transform.localScale.y - _additionalScale;

        SpawnPlatform(_spawnPlatform, ref spawnPosition, _deam.transform);

         for (int i = 0; i < _towerBuilder.LevelCount; i++)
        {
            SpawnPlatform(_platform[Random.Range(0, _platform.Length)], ref spawnPosition, _deam.transform);
        }

        SpawnPlatform(_finishPlatform, ref spawnPosition, _deam.transform);
    }

    private void SpawnPlatform(Platform platform, ref Vector3 spawnPosition, Transform parent)
    {
        Instantiate(platform, spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), parent);
        spawnPosition.y -= 1;
    }
}
