using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
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
