using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float jumpForce = 100f;
    
    [Header("Audio effects")]
    public AudioClip jumpSound;
    public AudioClip dieSound;
    public AudioClip scoreSound;
    
    private Rigidbody2D rb;
    private AudioSource audioSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && rb.velocity.y < 0)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            audioSource.PlayOneShot(jumpSound);
        }

        if (rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.CompareTag("Pipe"))
        {
            audioSource.PlayOneShot(scoreSound);
        }
    }
}
