using UnityEngine;
using Zenject;

public class Ball : MonoBehaviour
{ 
    public int hp;
    
     private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlatformSigment platfirmSigment))
        {
           other.GetComponentInParent<Platform>().Break();
           other.GetComponentInParent<Platform>().Minuc();
        }
    }
}
