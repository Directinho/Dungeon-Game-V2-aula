using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
