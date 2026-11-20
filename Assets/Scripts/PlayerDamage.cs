using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int damageAmount = 20;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.TakeDamage(damageAmount);
            }
        }
    }
}