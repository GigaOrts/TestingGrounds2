using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -50;
    private float bottomLimit = -5;

    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}