using UnityEngine;

public class shield : MonoBehaviour
{
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
        transform.position = mousePos;
    }
}
