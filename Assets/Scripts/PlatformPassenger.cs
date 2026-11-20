using UnityEngine;

public class PlatformPassenger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MovingPlatform>() != null)
        {
            transform.SetParent(collision.transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MovingPlatform>() != null)
        {
            transform.SetParent(null);
        }
    }
}