using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTouch : MonoBehaviour, IInputTouch
{ 
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
