using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCamera : MonoBehaviour
{
      [SerializeField] private Vector3 _directionOffSet;
    [SerializeField] private float _lenght;
    private Beam _beam;
    private Ball _ball;

    private Vector3 _cameraPosition;
    private Vector3 _minimumBallPosition;

    private void Awake()
    {
        _beam = FindObjectOfType<Beam>();
        _ball = FindObjectOfType<Ball>();

        _cameraPosition = _ball.transform.position;
        _minimumBallPosition = _ball.transform.position;

        TrackBall();
    }

    private void Update()
    {
        if(_ball.transform.position.y < _minimumBallPosition.y)
        {
            TrackBall();
            _minimumBallPosition = _ball.transform.position; 
        }
    }

    private void TrackBall()
    {
        Vector3 beamPosition = _beam.transform.position;
        beamPosition.y = _ball.transform.position.y;
        _cameraPosition = _ball.transform.position;
        Vector3 direction = (beamPosition - _ball.transform.position).normalized + _directionOffSet;
        _cameraPosition -= direction * _lenght;
        transform.position = _cameraPosition;
        transform.LookAt(_ball.transform);
    }
}
