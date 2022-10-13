using UnityEngine;

public class LowerBoundsDestroy : MonoBehaviour
{
    private float lowerBounds = -20f;

    void Update()
    {
        if (transform.position.z < lowerBounds)
            Destroy(gameObject);
    }
}
