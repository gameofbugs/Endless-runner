using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloaMainMenu : MonoBehaviour
{

  public void OnRetryButtonClicked()
    {
        Time.timeScale= 1.0f;
        SceneManager.LoadScene("MainScene");
    }
    public void OnPlayButtonClicked()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainScene");
    }
}
