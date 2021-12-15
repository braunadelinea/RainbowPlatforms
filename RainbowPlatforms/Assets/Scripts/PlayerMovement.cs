using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D Player;
    public float Speed = 5;
    private float JumpForce = 3.5f;
    private float HorizontalInput;
    private Vector3 JumpVector;
    public Collider2D Ground;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        JumpVector = new Vector3(0.0f, 2.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        Player.velocity = new Vector2(HorizontalInput * Speed, Player.velocity.y);

        //add direction checks once we have an actual sprite

    }

    private void OnCollisionEnter2D(Collision2D Ground)
    {
        Player.AddForce(JumpVector * JumpForce, ForceMode2D.Impulse);

    }
    
}
