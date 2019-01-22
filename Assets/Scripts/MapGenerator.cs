using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MapDisplay))]
public class MapGenerator : MonoBehaviour
{
    public int mapWidht;
    public int mapHeight;
    public float noiseScale;

    public bool autoUpdate;

    public void GenenerateMap()
    {
        float[,] map = Noise.GenerateNoiseMape(mapWidht,mapHeight,noiseScale);

        MapDisplay mapDisplay = FindObjectOfType<MapDisplay>();
        mapDisplay.DrawMap(map);
    }
}
