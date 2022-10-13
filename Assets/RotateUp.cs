using UnityEngine;

public class RotateUp : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
