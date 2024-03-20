using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    float size = 1.0f;
    int score = 1;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        float x = Random.Range(-2.4f, 2.4f);
        float y = Random.Range(3.0f, 4.5f);

        transform.position = new Vector3(x, y, 0);

        int type = Random.Range(1, 5); // [1,4) 형태로 뽑아준다

        switch (type)
        {
            case 1:
                size = 0.8f;
                score = 1;
                spriteRenderer.color = new Color(100 / 255f, 100 / 255f, 1f, 1f);
                break;
            case 2:
                size = 1.0f;
                score = 2;
                spriteRenderer.color = new Color(130 / 255f, 130 / 255f, 1f, 1f);
                break;
            case 3:
                size = 1.2f;
                score = 3;
                spriteRenderer.color = new Color(150 / 255f, 150 / 255f, 1f, 1f);
                break;
            case 4:
                size = 0.8f;
                score = -5;
                spriteRenderer.color = new Color(255 / 255.0f, 100.0f / 255.0f, 100.0f / 255.0f, 255.0f / 255.0f);
                break;
        }

        transform.localScale = new Vector3(size, size, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(score);
            Destroy(this.gameObject);
        }
    }
}
