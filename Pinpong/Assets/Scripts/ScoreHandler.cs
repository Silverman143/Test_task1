using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScoreTMP;
    [SerializeField] private TextMeshProUGUI _bestScoreTMP;
    private DataController _dataController;
    private int _currentScore = 0;
    private int _bestScore = 0;

    private void Awake()
    {
        _dataController = FindObjectOfType<DataController>();
        RocketController[] _rockets = FindObjectsOfType<RocketController>();
        foreach(RocketController _rocket in _rockets)
        {
            _rocket._onHitBall.AddListener(UploadCurrentScore);
        }

        OutZoneHandler[] _outZones = FindObjectsOfType<OutZoneHandler>();
        foreach (OutZoneHandler _zone in _outZones)
        {
            _zone._onOutZone.AddListener(ResetCurrentScore);
        }
    }

    private void Start()
    {
        
        UploadBestScore();
        UploadCurrentScore(0);
    }

    private void ResetCurrentScore()
    {
        SaveScore();
        _currentScore = 0;
        UploadCurrentScore(0);
        UploadBestScore();
    }

    private void UploadCurrentScore(int _add)
    {
        _currentScore += _add;
        _currentScoreTMP.text = "Current Score: " + _currentScore.ToString();
    }
    private void UploadBestScore()
    {
        _bestScore = _dataController.GetBestScore();
        _bestScoreTMP.text ="Best Score: "+ _bestScore.ToString();
    }
    private void SaveScore()
    {
        if (_currentScore > _bestScore)
        {
            _dataController.UploadBestScore(_currentScore);
        }
    }
    public int GetCurrentScore()
    {
        return _currentScore;
    }

    public int GetBestScore()
    {
        return _bestScore;
    }
}
