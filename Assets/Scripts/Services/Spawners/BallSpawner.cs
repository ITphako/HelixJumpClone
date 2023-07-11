using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

       [SerializeField] private Ball _ball;
        [SerializeField] private Transform _spawnTransform;

private void Awake()
{
   var ball =  Instantiate(_ball,_spawnTransform.position, Quaternion.identity);
}

public void SpawnerBall()
{
    var ball =  Instantiate(_ball,_spawnTransform.position, Quaternion.identity);
}
}
