using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BallCharacteristic
{
    [SerializeField] private float _size;
    [SerializeField] private float _speed;

    public float GetSize()
    {
        return _size;
    }

    public float GetSpeed()
    {
        return _speed;
    }

}

public class BallsCharacteristics : MonoBehaviour
{
    [SerializeField] private BallCharacteristic[] _allCharacteristics;

    public BallCharacteristic GetRandomCharacteristic()
    {
        return _allCharacteristics[Random.Range(0, _allCharacteristics.Length)];
    }
}
