using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    [SerializeField] private TMP_Text scoreText;

    public void AddPoint()
    {
        score++;
        scoreText.text = "Очки: " + score;
    }
}