using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlatformGeneration : MonoBehaviour
{
    public int NumOfPlaftorms;
    public GameObject Platform;

    public float MinY;
    public float MinX;
    public float MaxX;
    public float MinGap;
    public float MaxGap;

    public float PlatformDistribution;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePlatforms();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GeneratePlatforms()
    {
        System.Random rand = new System.Random();
        float currentHeight = MinY;
        float xRange = MaxX - MinX;
        float yRange = MaxGap - MinGap;

        for(int i = 0; i < NumOfPlaftorms; i++)
        {
            float xPos = (float) rand.NextDouble() * xRange + MinX;
            float yPos = (float) Math.Pow(rand.NextDouble(), PlatformDistribution) * yRange + MinGap + currentHeight;
            Instantiate(Platform, new Vector3(xPos, yPos), Quaternion.identity);
            currentHeight = yPos;
        }
    }
}
