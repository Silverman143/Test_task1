using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreTMP;
    private DataController _dataController;

    private void Awake()
    {
        _dataController = FindObjectOfType<DataController>();   
    }

    private void Start()
    {
        LoadBestScore();
    }

    private void LoadBestScore()
    {
        string _bestScore = _dataController.GetBestScore().ToString();
        _scoreTMP.text = "Best score: \n" + _bestScore;
    }
}
