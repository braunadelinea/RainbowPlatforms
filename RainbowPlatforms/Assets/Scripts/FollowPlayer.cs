using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    float HighestHeight = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerHeight = player.GetComponent<Transform>().position.y;

        if (playerHeight > HighestHeight)
        {
            gameObject.GetComponent<Transform>().position =
                new Vector3(gameObject.GetComponent<Transform>().position.x, playerHeight, -10);
            HighestHeight = playerHeight;
        }
    }
}
