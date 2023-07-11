using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
  public int hp;

  private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out BVaric vVaric))
        {
            vVaric.HHHp = 100;
        }
    } 
}
