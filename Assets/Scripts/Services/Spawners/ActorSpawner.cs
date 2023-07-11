using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

 public class ActorSpawner : ActorSpawnerBase
    {
       [SerializeField] private Ball _ball;

        private int _currentActorIndex;
        private IRandomizer _randomizer;


        [Inject]
        private void Construct(IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }

        private void Awake()
        {
            StartSpawn();
        }

        public override void StartSpawn()
        {
            StartCoroutine(SpawnProcess());
        }

        public override void StopSpawn()
        {
            StopAllCoroutines();
        }

        private IEnumerator SpawnProcess()
        {
            while (true)
            {
                Instantiate(_ball,_spawnTransform.position, Quaternion.identity);
            }
        }

    }
