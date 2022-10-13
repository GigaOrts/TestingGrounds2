using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject projectile;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
