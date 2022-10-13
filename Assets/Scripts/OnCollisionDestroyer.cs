using UnityEngine;

public class OnCollisionDestroyer : MonoBehaviour
{
    [SerializeField] private Player playerTemp;

    private int onCollisionDamage = 1;
    private int onCollisionScore = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.TakeDamage(onCollisionDamage);
        }

        if (other.TryGetComponent(out Projectile _))
        {
            playerTemp.AddScore(onCollisionScore);
            Destroy(other.gameObject);
        }

        Destroy(gameObject);
    }
}