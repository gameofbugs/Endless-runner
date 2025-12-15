using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    private int score = 0;
    private int highScore = 0;
    private float scoreinterval=1f;
    private float scoreTimer = 0f;
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HIGH SCORE:", 0);
        scoreText.text = "SCORE"+score.ToString();
        highScoreText.text = "HIGH SCORE:" + highScore.ToString();
    }

   
    void Update()
    {
        scoreTimer+= Time.deltaTime;
        if(scoreTimer>=scoreinterval)
        {
            score++;
            scoreTimer = 0f;
            scoreText.text = "SCORE:" + score.ToString();
        } 
        if(score>highScore)
        {
            highScore = score;
            highScoreText.text = "HIGH SCORE:" + highScore.ToString();
            PlayerPrefs.SetInt("HIGH SCORE:", highScore);
            PlayerPrefs.Save();
        }
    }
}
