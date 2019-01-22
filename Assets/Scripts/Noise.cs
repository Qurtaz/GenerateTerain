using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise
{
    public static float[,] GenerateNoiseMape(int mapWidht,int mapHeight, float sacle)
    {
        float[,] noiseMap = new float[mapWidht, mapHeight];
        if(sacle <=0)
        {
            sacle = 0.00001f;
        }
        for(int y = 0; y <mapHeight; y++)
        {
            for(int x =0; x< mapWidht; x++)
            {
                float sampleX = x/sacle;
                float sampleY = y/sacle;

                float perlinValue = Mathf.PerlinNoise(sampleX,sampleY);
                noiseMap[x, y] = perlinValue;
            }
        }

        return noiseMap;
    }
}
