using UnityEngine;
using UnityEngine.UI; 

public class Scorefinal : MonoBehaviour
{
    public int score = 0; 
    public Text scoreText; 
    public Text messageText; 

    void Start()
    {
        UpdateScoreText();
        messageText.gameObject.SetActive(false); 
    }

    public void AddScore(int amount)
    {
        score += amount; 
        UpdateScoreText();

        if (score >= 6)
        {
            ShowMessage();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); 
    }

    void ShowMessage()
    {
        messageText.gameObject.SetActive(true); 
    }
}