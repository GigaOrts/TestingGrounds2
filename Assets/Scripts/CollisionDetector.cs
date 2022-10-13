using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private GameController game;

    private void Start()
    {
        game = FindObjectOfType<GameController>().GetComponent<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player _)) 
        {
            game.ChangeLives(-game.Lives);
        }
        else if (other.TryGetComponent(out Animal _))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            game.AddScore(5);
        }
    }
}