using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public GameObject food;
    private void Start()
    {
        InvokeRepeating("MakeFood", 0.0f, 0.5f);
    }
    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = mousePos.x;
        if(x > 8.5f)
        {
            x = 8.5f;
        }
        if (x < -8.5f)
        {
            x = -8.5f;
        }

        transform.position = new Vector2(x, transform.position.y);
    }
    void MakeFood()
    {
        Instantiate(food, transform.position + Vector3.up * 2.0f, Quaternion.identity);
    }
}
