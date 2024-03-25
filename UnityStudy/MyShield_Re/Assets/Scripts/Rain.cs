using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-3.0f, 3.0f);
        float y = Random.Range(5.0f, 1.5f);
        transform.position = new Vector3(x, y, 0);

        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(size, size, 1);
    }
    private void Update()
    {
        if(transform.position.y < -6.0f)
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
