using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; 
    public int score = 0; 
    public TMPro.TextMeshProUGUI scoreText; 
    public TMPro.TextMeshProUGUI messageText;
    public GameObject nextpopup;
    public TMPro.TextMeshProUGUI text;

     void Start()
    {
        UpdateScoreText();
        messageText.gameObject.SetActive(false); 
        nextpopup.SetActive(false);
        text.gameObject.SetActive(false);
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); 
        }

        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        Debug.Log("Current Score: " + score);

        if (score >= 6)
        {
            Shownextpopup();
            text.gameObject.SetActive(true);
        }
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = " " + score; 
        }
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClosenextPopup(); 
            text.gameObject.SetActive(false);
        }
    }
    void Shownextpopup()
    {
        nextpopup.SetActive(true);
    }

    void ClosenextPopup()
    {
        nextpopup.SetActive(false); 
    }
}
