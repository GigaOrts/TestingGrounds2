using UnityEngine;

public class OnCollisionDestroyer : MonoBehaviour
{
    private int onCollisionDamage = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player)) 
        {
            player.TakeDamage(onCollisionDamage); 
        }
        else
        {
            Destroy(other.gameObject);
        }

        Destroy(gameObject);
    }
}