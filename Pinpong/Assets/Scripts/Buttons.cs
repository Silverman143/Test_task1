using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject _colorPanel;

    public void MultiplayerButton()
    {
        SceneManager.LoadScene("MultiplayerGame");
    }

    public void SoloGame()
    {
        SceneManager.LoadScene("SoloGame");
    }

    public void ShowColorPanel()
    {
        _colorPanel.SetActive(true);
    }

    public void HideColorPanel()
    {
        _colorPanel.SetActive(false);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
