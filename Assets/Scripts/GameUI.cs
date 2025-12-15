using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    public TMP_Text scoreText;
    int score=0;

    private void Start()
    {
        ResetScore();
    }

    private void Update()
    {
        
    }

    // 「重設分數」的方法
    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    // 「加分」的方法
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
