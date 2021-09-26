using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;
    private static Color _ballColor;

    private void Awake()
    {
        _ballPrefab = Resources.Load<GameObject>("BallPref");

        OutZoneHandler[] _outZones = FindObjectsOfType<OutZoneHandler>();
        foreach(OutZoneHandler _zone in _outZones)
        {
            _zone._onOutZone.AddListener(Create_ball);
        }
        
    }
    private void Start()
    {
        Create_ball();
    }

    private void Create_ball()
    {
        GameObject _newBall = Instantiate(_ballPrefab);
    }

    
}
