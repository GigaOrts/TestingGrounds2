using UnityEngine;

public class HigherBoundsDestroy : MonoBehaviour
{
    private float higherBounds = 10f;

    void Update()
    {
        if (transform.position.z > higherBounds)
            Destroy(this);
    }
}
