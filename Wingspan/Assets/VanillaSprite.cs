using Unity.Transforms;
using UnityEngine;
using System.IO;

public class VanillaSprite : MonoBehaviour
{
    public Sprite spritePrefab;   // The sprite prefab to be spawned
    public Vector3 spawnPosition; // The position to spawn the sprite
    // Start is called before the first frame update
    void Start()
    {
        print("1");
        string filePath = "C:/Users/adam/Documents/GitHub/Wingspan/Wingspan/Builds/Wingspan_Data/StreamingAssets/lidar_data.txt";
        //string filePath = Application.streamingAssetsPath + "/lidar_data.txt";
        string[] lines = File.ReadAllLines(filePath);
        int pointCount = lines.Length;
        print("2");


        Vector3[] positions = new Vector3[pointCount];
        for (int i = 0; i < lines.Length / 10; i++)
        {
            GameObject spriteObject = new GameObject("Sprite"); // Create a new game object to hold the sprite
            var trans = new LocalTransform { Scale = 1 };
            string[] values = lines[i].Split(',');
            trans.Position.x = (float.Parse(values[0]) / 10) - 182600;
            trans.Position.y = float.Parse(values[2]) / 10 - 70;
            trans.Position.z = (float.Parse(values[1]) / 10) - 71000;

            spriteObject.transform.position = trans.Position;
            SpriteRenderer spriteRenderer = spriteObject.AddComponent<SpriteRenderer>(); // Add a sprite renderer component
            spriteRenderer.sprite = spritePrefab;
            //Debug.Log(trans.Position);
        }
    }
}
