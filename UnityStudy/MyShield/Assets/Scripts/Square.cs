using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private void Start()
    {
        float x = Random.Range(-3.0f, 3.0f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector2(x, y);

        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector2(size, size);
    }
    private void Update()
    {
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}