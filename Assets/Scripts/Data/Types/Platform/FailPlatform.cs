using Zenject;
using UnityEngine;

public class FailPlatform : MonoBehaviour
{
     [SerializeField] private BallJumper _ballJumper;
    
    private void Awake()
    {
      _ballJumper = FindObjectOfType<BallJumper>();
    }

   public void Fail()
   {
    _ballJumper.StopForce();
   }
}
