using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
     [SerializeField]private Cube _ball;



private void Awake()
{
   var ball =  Instantiate(_ball, transform.position, Quaternion.identity);
   _ball = FindObjectOfType<Cube>();
   Count(ball);
}

private void Update()
{
   _ball.hp++;
}

private void Count(Cube ball)
{
    ball.hp = 990;
}

}
