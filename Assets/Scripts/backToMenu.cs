using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}