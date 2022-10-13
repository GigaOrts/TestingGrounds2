using UnityEngine;

public class OutOfBoundsDestroy : MonoBehaviour
{
    private GameController game;

    private float bounds = 26f;
    private bool outOfBoundsX;

    private void Start()
    {
        game = FindObjectOfType<GameController>().GetComponent<GameController>();
    }

    void Update()
    {
        outOfBoundsX = transform.position.x > bounds || transform.position.x < -bounds;

        if (outOfBoundsX || transform.position.z < -bounds)
        {
            game.ChangeLives(-1);
            Destroy(gameObject);
        }
        if (transform.position.z > bounds)
        {
            Destroy(gameObject);
        }
    }
}