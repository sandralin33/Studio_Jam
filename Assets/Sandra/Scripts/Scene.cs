using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application has Quit");
    }
}
