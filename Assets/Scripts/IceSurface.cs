using UnityEngine;

public class IceSurface : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.rigidbody;

        if (rb != null && collision.gameObject.CompareTag("Player"))
        {
            rb.sharedMaterial = null;
            rb.linearDamping = 0f;
        }
    }
}