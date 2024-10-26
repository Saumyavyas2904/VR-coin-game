using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip hitSurfaceClip; 
    public AudioClip hitDustbinClip; 
    public AudioClip insideDustbinClip; 
    
    public GameObject dustbin;  // Dustbin GameObject
    public GameObject bucket;   // Bucket GameObject, now declared
    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the coin hits the dustbin
        if (collision.gameObject == dustbin)
        {
            PlaySound(hitDustbinClip);  // Fixed the clip to be hitDustbinClip
        }
        else
        {
            PlaySound(hitSurfaceClip);  // Play surface sound if it hits anything else
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the coin enters the bucket
        if (other.gameObject == bucket)
        {
            PlaySound(insideDustbinClip);  // Fixed the clip to insideDustbinClip
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}
