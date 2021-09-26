using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private DataBase _dataBase;

    private void Awake()
    {
        _dataBase = FindObjectOfType<DataBase>();
    }

    public int GetBestScore()
    {
        int _bestScore = 0;
        _bestScore = _dataBase.GetIntData("intValue", "Game_data", "Best_score", "dataType" );
        return _bestScore;
    }

    public void UploadBestScore(int _value)
    {
        _dataBase.UpdateIntData("intValue", _value, "Game_data", "dataType", "Best_score");
    }

    public void UploadBallColor(string _color)
    {
        _dataBase.UpdataStrinData("stringValue", "#"+_color, "Game_data", "dataType", "Ball_color");
    }

    public Color GetBallCurrenColor()
    {
        Color _currentColor = new Color();
        string _htmlColor = _dataBase.GetStringData("stringValue", "Game_data", "Ball_color", "dataType");
        if (ColorUtility.TryParseHtmlString(_htmlColor, out _currentColor))
        {
            return _currentColor;
        }
        

        return _currentColor;
    }
}
