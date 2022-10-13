using UnityEngine;

public class Player : MonoBehaviour
{
    public int Score { get; private set; }
    public int Lives { get; private set; } = 5;

    public void TakeDamage(int damage)
    {
        Lives -= damage;
        Debug.Log("Lives: " + Lives);

        if (Lives <= 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }

    public void AddScore(int score)
    {
        Score += score;
        Debug.Log("Score: " + Score);
    }
}