
using Zenject;

public class ActorSpawnerAfterDead : ActorSpawnerBase
    {
        private int _currentActorIndex;
        private Actor _currentActor;

        private IRandomizer _randomizer;

        [Inject]
        private void Construct(IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }

        public override void StartSpawn()
        {
            SpawnActor();
        }

        public override void StopSpawn()
        {
            
        }

        private void SpawnActor()
        {
          
        }

        
    }
