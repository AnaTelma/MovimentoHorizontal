using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float moveH;
    private Rigidbody2D player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        player.linearVelocity = new Vector2(moveH * speed, player.linearVelocityY);
        
    }
}
