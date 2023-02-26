using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.UIElements;

public class ParticleCloud : MonoBehaviour
{
    public GameObject particlePrefab;  // The particle prefab to be spawned
    public Vector3 spawnPosition;      // The position to spawn the particle
    // Start is called before the first frame update
    void Start()
    {
        string filePath = "C:/Users/adam/Documents/GitHub/Wingspan/Wingspan/Builds/Wingspan_Data/StreamingAssets/lidar_data.txt";
        //string filePath = Application.streamingAssetsPath + "/lidar_data.txt";
        string[] lines = File.ReadAllLines(filePath);
        int pointCount = lines.Length;
        print("2");
        Vector3[] positions = new Vector3[pointCount];
        for (int i = 0; i < lines.Length / 10; i++)
        {
            var trans = new LocalTransform { Scale = 1 };
            string[] values = lines[i].Split(',');
            trans.Position.x = (float.Parse(values[0]) / 10) - 182600;
            trans.Position.y = float.Parse(values[2]) / 10 - 70;
            trans.Position.z = (float.Parse(values[1]) / 10) - 71000;
            GameObject particle = Instantiate(particlePrefab, trans.Position, Quaternion.identity);
            particle.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            //Debug.Log(trans.Position);
        }
        //GameObject particle = Instantiate(particlePrefab, position, Quaternion.identity);
        // Spawn the particle prefab at the specified position with no rotation
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
