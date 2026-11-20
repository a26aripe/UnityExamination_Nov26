using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class GroundSound : MonoBehaviour
{
    [Header("Drag your sound here")]
    public AudioClip soundToPlay;

    private AudioSource audioSource;

    void Start()
    {
        GetComponent<Collider2D>().isTrigger = true;

        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.playOnAwake = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && soundToPlay != null)
        {
            audioSource.PlayOneShot(soundToPlay);
        }
    }
}
