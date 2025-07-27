using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; 

    private int score = 0;

    [SerializeField] private TMP_Text scoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score;
        Debug.Log("Score: " + score);
    }
}