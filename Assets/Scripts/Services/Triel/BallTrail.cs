using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BallTrail : MonoBehaviour
{ 
    [SerializeField] private MeshRenderer _visualModel;
    [SerializeField] private Blot _blotPrefab;
    public float offsetZ;

    public void OnBallCollisionSegment(Transform parent)
    {
            Blot blot = Instantiate(_blotPrefab, parent);

            blot.Init(
                new Vector3(transform.position.x, transform.position.y + offsetZ, transform.position.z), _visualModel.material.color);
    }

     private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out FinishPlatform finish))
        {
            finish.isFinish = true;
        }
    }
}

