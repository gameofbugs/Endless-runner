using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnJump : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Time.timeScale =0f;
            StartCoroutine(GameOverScene());
        }
    }
    IEnumerator GameOverScene()
    {
        yield return new WaitForSecondsRealtime(5f);
        SceneManager.LoadScene("GameOver");
    }
}
