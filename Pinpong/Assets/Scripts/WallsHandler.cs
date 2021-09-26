using UnityEngine.SceneManagement;
using UnityEngine;

public class WallsHandler : MonoBehaviour
{
    [SerializeField] private Transform _leftWall;
    [SerializeField] private Transform _rightWall;
    [SerializeField] private Transform _uprightWall;
    [SerializeField] private Transform _bottomWall;

    private float _screenHeight;
    private float _screenWidth;

    private bool _isMultiplayer = false;

    private void Awake()
    {
        _isMultiplayer = SceneManager.GetActiveScene().name == "MultiplayerGame";
    }

    private void Start()
    {
        _screenHeight = Camera.main.orthographicSize*2;
        _screenWidth = Camera.main.aspect * _screenHeight;

        SetWallsParams();
    }

    private void SetWallsParams()
    {
        _leftWall.position = GetLeftWallPos();
        _leftWall.GetComponent<BoxCollider2D>().size = new Vector2 (0.01f, _screenHeight);

        _rightWall.position = GetRightWallPos();
        _rightWall.GetComponent<BoxCollider2D>().size = new Vector2(0.01f, _screenHeight);
        if (!_isMultiplayer)
        {
            _uprightWall.position = GetUprightWallPos();
            _uprightWall.GetComponent<BoxCollider2D>().size = new Vector2(0.01f, _screenWidth);

            _bottomWall.position = GetBottomWallPos();
            _bottomWall.GetComponent<BoxCollider2D>().size = new Vector2(0.01f, _screenWidth);
        }
        else
        {
            _uprightWall.position = GetUprightWallPos();
            _uprightWall.GetComponent<BoxCollider2D>().size = new Vector2(_screenWidth, 0.01f);

            _bottomWall.position = GetBottomWallPos();
            _bottomWall.GetComponent<BoxCollider2D>().size = new Vector2(_screenWidth, 0.01f);
        }
        
    }

    private Vector2 GetLeftWallPos()
    {
        Vector2 _pos = new Vector2();
        _pos = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/2, 0));
        return _pos;
    }

    private Vector2 GetRightWallPos()
    {
        Vector2 _pos = new Vector2();
        _pos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, 0));
        return _pos;
    }

    private Vector2 GetUprightWallPos()
    {
        Vector2 _pos = new Vector2();
        _pos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height, 0));
        Debug.Log(Screen.height);
        return _pos;
    }

    private Vector2 GetBottomWallPos()
    {
        Vector2 _pos = new Vector2();
        _pos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0, 0));
        return _pos;
    }

    public void SetBottomWall(Transform _wall)
    {
        Destroy(_bottomWall.gameObject);
        _bottomWall = _wall;
    }

    public void SetUprightWall(Transform _wall)
    {
        Destroy(_uprightWall.gameObject);
        _uprightWall = _wall;
    }
}
