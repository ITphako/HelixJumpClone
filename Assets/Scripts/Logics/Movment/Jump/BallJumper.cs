using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BallJumper : MonoBehaviour
{ 
    private BallTrail _ballTrail;
    [SerializeField] private float _jumpForce;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _ballTrail = GetComponent<BallTrail>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlatformSigment platformSigment))
        {
           Transform parent = platformSigment.transform;
            _ballTrail.OnBallCollisionSegment(parent);
            StopForce();
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }

    public void StopForce()
    {
            _rigidbody.velocity = Vector3.zero;
    }
}