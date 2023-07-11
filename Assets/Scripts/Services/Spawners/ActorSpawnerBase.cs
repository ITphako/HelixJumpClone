using UnityEngine;
using Zenject;
 public abstract class ActorSpawnerBase : MonoBehaviour
    {
        [SerializeField] protected Transform _spawnTransform;
        [SerializeField] protected Transform _targetTransform;
        [SerializeField] protected float _spawnAdgeLength;
        [SerializeField] protected float _interval;
        [SerializeField][Range(0.1f, 1.0f)] protected float _offsetInterval;
        [SerializeField] protected EActorType[] _spawnActorsType;



        [Inject]
        private void Construct()
        {
        }

        public virtual void StartSpawn()
        {

        }

        public virtual void StopSpawn()
        {

        }

#if UNITY_EDITOR

        [Header("ONLY EDITOR!")]
        [SerializeField] private Color _sphereColor;
        [SerializeField] private float _sphereRadius;
        [SerializeField] private bool _isDisplaying;

        private void OnDrawGizmos()
        {
            if (_isDisplaying)
            {
                Gizmos.color = _sphereColor;

                Gizmos.DrawSphere(transform.position, _sphereRadius);
                Gizmos.DrawSphere(transform.position + transform.right * _spawnAdgeLength, _sphereRadius);
                Gizmos.DrawRay(transform.position, transform.right * _spawnAdgeLength);
            }
        }

#endif
    }