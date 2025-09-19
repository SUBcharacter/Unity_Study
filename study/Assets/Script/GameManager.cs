using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] float scoreTime = 0;
    
    public void InitScoreTime()
    {
        scoreTime = 0;
    }

    public void GetScore()
    {
        scoreTime += Time.deltaTime;

        if (scoreTime >= 1f)
        {
            score++;
            scoreTime = 0;
        }
    }
}
