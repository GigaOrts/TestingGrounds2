using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform projectileCanon;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectile, projectileCanon.position, Quaternion.identity);
    }
}
