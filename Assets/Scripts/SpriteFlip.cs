 using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = true;
        }
    }
}
