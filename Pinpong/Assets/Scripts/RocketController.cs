using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RocketController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _rocket;

    //Pos restrictions
    [SerializeField] private float _maxX;
    [SerializeField] private float _minX;

    private Vector2 _moveDirection;

    public UnityEvent<int> _onHitBall;

    private void Start()
    {
        Get_position_restrictions();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.touchCount > 0)
        {
            Touch _touch = Input.GetTouch(0);
            switch (_touch.phase)
            {
                case TouchPhase.Moved:
                    Vector2 _newPos = Camera.main.ScreenToWorldPoint(_touch.position);
                    _newPos.y = transform.position.y;
                    _newPos = Normalize_pozition(_newPos);
                    transform.position = Vector2.Lerp(transform.position, _newPos, 0.15f);
                    CountMoveDirection(_newPos);
                    break;
            }
            
        }
    }

    private void Get_position_restrictions()
    {
        float _halfWidth = _rocket.bounds.size.x/2 * _rocket.transform.localScale.x;
        _maxX -= _halfWidth;
        _minX += _halfWidth;
    }

    private Vector2 Normalize_pozition(Vector2 _pos)
    {
        _pos.x = Mathf.Clamp(_pos.x, _minX, _maxX);
        return _pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<BallController>(out BallController _ball))
        {
            _onHitBall.Invoke(1);
        }
    }

    private void CountMoveDirection(Vector2 _targetPos)
    {
        _moveDirection = new Vector2(_targetPos.x - transform.position.x, _targetPos.y - transform.position.y);
    }

    public Vector2 GetMoveDirection()
    {
        return _moveDirection;
    }
}
