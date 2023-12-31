using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlatformSigment : MonoBehaviour
{

     public void Bounce(float force, Vector3 centre, float radius)
    {
        if(TryGetComponent(out Rigidbody rigidbody))
        {
            rigidbody.isKinematic = false; 
            rigidbody.AddExplosionForce(force, centre, radius);
        }
    }
}
