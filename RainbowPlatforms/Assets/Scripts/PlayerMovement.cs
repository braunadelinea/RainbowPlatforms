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

    private bool OnGround = true;

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

        if (Input.GetKeyDown(KeyCode.W) && OnGround == true || Input.GetKeyDown(KeyCode.UpArrow) && OnGround == true)
        {
            Player.AddForce(JumpVector * JumpForce, ForceMode2D.Impulse);
        }

        //add direction checks once we have an actual sprite

    }
}
