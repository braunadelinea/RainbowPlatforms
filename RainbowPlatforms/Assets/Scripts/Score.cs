using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject Player;
    public float CurrentY;
    public float HighScore;

    // Start is called before the first frame update
    void Start()
    {
        HighScore = -10;
    }

    // Update is called once per frame
    void Update()
    {
        //save current position as previous
        CurrentY = Player.GetComponent<Transform>().position.y;
        print("Current Y: " + CurrentY);
        if (CurrentY > HighScore)
        {
            HighScore = Player.GetComponent<Transform>().position.y;
            print("New Highest Y: " + HighScore);
        }

    }

}
