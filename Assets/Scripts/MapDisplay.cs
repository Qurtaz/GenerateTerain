using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MapGenerator))]
public class MapDisplay : MonoBehaviour
{
    public Renderer textureRenderer;

    public void DrawMap(float [,] noiseMap)
    {
        int widht = noiseMap.GetLength(0);
        int height = noiseMap.GetLength(1);

        Texture2D texture = new Texture2D(widht, height);

        Color[] colourMap = new Color[widht*height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < widht; x++)
            {
                colourMap[y * widht + x] = Color.Lerp(Color.black, Color.white, noiseMap[x,y]);
            }
        }
        texture.SetPixels(colourMap);
        texture.Apply();

        textureRenderer.sharedMaterial.mainTexture = texture;
        textureRenderer.transform.localScale = new Vector3(widht, 1, height);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
