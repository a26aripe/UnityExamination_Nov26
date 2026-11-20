using UnityEngine;
public class IceMovement : MonoBehaviour
{
    public float acceleration = 8f;
    public float maxSpeed = 8f;
    public float friction = 0.2f;

    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        if (moveInput != 0)
        {
            rb.AddForce(Vector2.right * moveInput * acceleration);
        }
        else
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x * (1f - friction * Time.fixedDeltaTime),
                rb.linearVelocity.y
            );
        }

        rb.linearVelocity = new Vector2(
            Mathf.Clamp(rb.linearVelocity.x, -maxSpeed, maxSpeed),
            rb.linearVelocity.y
        );
    }
}