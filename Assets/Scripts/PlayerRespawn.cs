using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector2 checkpointPosition;
    private Rigidbody2D rb;
    public AudioSource AudioSource;
    public AudioClip deadsound;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        checkpointPosition = transform.position;

    }

    public void SetCheckpoint(Vector2 newCheckpoint)
    {
        checkpointPosition = newCheckpoint;
    }

    public void Die()
    {
        transform.position = checkpointPosition;
        rb.linearVelocity = Vector2.zero;

        AudioSource.PlayOneShot(deadsound);
    }
}