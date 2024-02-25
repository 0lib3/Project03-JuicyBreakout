using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Sprite closedMouthSprite;
    public Sprite tongueOutSprite; 
    private SpriteRenderer mouthSpriteRenderer;

    private void Start()
    {
        // Find the Mouth GameObject's SpriteRenderer
        mouthSpriteRenderer = transform.Find("Face/Mouth").GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            // Change Mouth's sprite to tongue out
            mouthSpriteRenderer.sprite = tongueOutSprite;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            // Change Mouth's sprite back to closed mouth
            mouthSpriteRenderer.sprite = closedMouthSprite;
        }
    }
}

