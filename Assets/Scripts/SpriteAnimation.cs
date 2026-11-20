using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{
    [Header("Idle Animation")]
    [SerializeField] private Sprite[] idleFrames;
    [SerializeField] private float idleFrameRate = 0.1f;

    [Header("Walking Animation")]
    [SerializeField] private Sprite[] walkFrames;
    [SerializeField] private float walkFrameRate = 0.1f;

    [Header("Jump Animation")]
    [SerializeField] private Sprite[] jumpFrames;
    [SerializeField] private float jumpFrameRate = 0.1f;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    private int currentFrame;
    private float timer;
    private string currentAnimation = "";

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // JUMPING OR FALLING
        if (Mathf.Abs(rb.linearVelocity.y) > 0.1f)
        {
            PlayAnimation("Jump", jumpFrames, jumpFrameRate);
        }

        // WALKING - CHECK KEYBOARD INPUT
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            PlayAnimation("Walk", walkFrames, walkFrameRate);
        }

        // IDLE
        else
        {
            PlayAnimation("Idle", idleFrames, idleFrameRate);
        }
    }

    void PlayAnimation(string animationName, Sprite[] frames, float frameRate)
    {
        if (frames == null || frames.Length == 0)
            return;

        if (currentAnimation != animationName)
        {
            currentAnimation = animationName;
            currentFrame = 0;
            timer = 0f;

            spriteRenderer.sprite = frames[0];
        }

        timer += Time.deltaTime;

        if (timer >= frameRate)
        {
            timer = 0f;
            currentFrame++;

            if (currentFrame >= frames.Length)
                currentFrame = 0;

            spriteRenderer.sprite = frames[currentFrame];
        }
    }
}