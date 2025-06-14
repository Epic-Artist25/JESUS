using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu: MonoBehaviour
{

    [SerializeField] private GameObject Canvas;

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}