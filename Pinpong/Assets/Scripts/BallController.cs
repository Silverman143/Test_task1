using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private SpriteRenderer _ballSprite;
    private DataController _dataController;

    private float _speed = 2;
    
    private Vector2 _moveVector;

    private void Awake()
    {
        _dataController = FindObjectOfType<DataController>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _ballSprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetBallColor();
        SetBallCharacteristics();
        _moveVector = RandomDirection();
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = _moveVector*_speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 _rocketMoveDirection = Vector2.zero;
        if (collision.transform.TryGetComponent<RocketController>(out RocketController _rocket))
        {
            _rocketMoveDirection = _rocket.GetMoveDirection();
        }
        _moveVector = Vector2.Reflect(_moveVector, collision.contacts[0].normal)+_rocketMoveDirection;
    }

    private Vector2 RandomDirection()
    {
        Vector2 _direction = new Vector2(Random.Range(-1f, 1f), Random.Range(0, 2) * 2 - 1); ;
        return _direction;
    }

    private void SetBallColor()
    {
        _ballSprite.color = _dataController.GetBallCurrenColor();
    }

    private void SetBallCharacteristics()
    {
        BallsCharacteristics _allBallsCharacteristics = GetComponent<BallsCharacteristics>();
        BallCharacteristic _currentCharacteristic = _allBallsCharacteristics.GetRandomCharacteristic();
        _speed = _currentCharacteristic.GetSpeed();
        float _size = _currentCharacteristic.GetSize();
        transform.localScale = new Vector3(_size, _size, 1);
    }
}
