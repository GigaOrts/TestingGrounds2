using UnityEngine;

public class OutOfBoundsDestroy : MonoBehaviour
{
    private float bounds = 26f;
    private bool outOfBoundsX;
    private bool outOfBoundsZ;

    void Update()
    {
        outOfBoundsX = transform.position.x > bounds || transform.position.x < -bounds;
        outOfBoundsZ = transform.position.z > bounds || transform.position.z < -bounds;

        if (outOfBoundsX || outOfBoundsZ)
            Destroy(gameObject);
    }
}