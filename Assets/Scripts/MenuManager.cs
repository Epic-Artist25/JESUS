using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager: MonoBehaviour
{

    [SerializeField] private string InGame;
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Options;
    [SerializeField] private GameObject HighScore;


    public void Play()
    {
        SceneManager.LoadScene("InGame");
    }
    public void OpenOptions()
    {
        Menu.SetActive(false);
        Options.SetActive(true);
    }
    public void CloseOptions()
    {
        Options.SetActive(false);
        Menu.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void HighScoreOpen()
    {
        Options.SetActive(false);
        HighScore.SetActive(true);
    }

    public void HighScoreClose()
    {
        Options.SetActive(true);
        HighScore.SetActive(false);
    }

}