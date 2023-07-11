using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody))]

public class TowerRotater : MonoBehaviour
  
{
    [SerializeField] private float _rotateSpeed;
   private Rigidbody _rigidbody; 

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            InputTouche(_rotateSpeed,_rigidbody);
        }
    }

    public void InputTouche(float speed, Rigidbody rigidbody)
    {
        Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                float torqye = touch.deltaPosition.x * Time.deltaTime * speed;
                rigidbody.AddTorque(Vector3.up * torqye);
            }
    }

}