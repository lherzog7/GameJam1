using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScritp : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void QuitGame()
    {
        Debug.Log("Quit Button Pressed!");
        Application.Quit();
        
    }

}
