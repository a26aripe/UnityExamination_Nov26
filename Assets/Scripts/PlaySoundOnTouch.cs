using UnityEngine;

public class PlaySoundOnTouch : MonoBehaviour
{
    public GameObject groundSoundsObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            groundSoundsObject.SetActive(true);
        }
    }
}