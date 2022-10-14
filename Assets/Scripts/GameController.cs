using UnityEngine;

public class GameController : MonoBehaviour
{
    public int Score { get; private set; } = 0;
    public int Lives { get; private set; } = 20;

    public void ChangeLives(int lives)
    {
        Lives += lives;
        
        Debug.Log("Lives: " + Lives);

        if (Lives <= 0)
            EndGame();
    }

    public void AddScore(int score)
    {
        Score += score;
        Debug.Log("Score: " + Score);
    }

    private void EndGame()
    {
        Debug.Log("GAME OVER");
        Time.timeScale = 0;
    }
}