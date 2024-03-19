using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera PlayerCamera;
    float dir = 0.05f;
    float screenWidth;
    SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        Application.targetFrameRate = 60;
        spriteRenderer = GetComponent<SpriteRenderer>();
        screenWidth = PlayerCamera.orthographicSize * Screen.width/Screen.height;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dir *= -1;
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
        if(transform.position.x > (screenWidth))
        {
            dir *= -1;
            spriteRenderer.flipX = true;
        }

        if (transform.position.x < -(screenWidth))
        {
            dir *= -1;
            spriteRenderer.flipX = false;
        }

        transform.position += Vector3.right * dir;
    }
}
