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
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
        }
    }
}