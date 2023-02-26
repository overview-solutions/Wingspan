using Unity.Transforms;
using UnityEngine;
using System.IO;

public class NormalLidar : MonoBehaviour
{
    public bool yes;
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
        for (int i = 0; i < lines.Length/10; i++)
        {
            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var trans = new LocalTransform { Scale = 1 };
            string[] values = lines[i].Split(',');
            trans.Position.x = (float.Parse(values[0]) / 10) - 182600;
            trans.Position.y = float.Parse(values[2]) / 10 - 70;
            trans.Position.z = (float.Parse(values[1]) / 10) - 71000;
            newCube.transform.position = trans.Position;
            newCube.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);    
            //Debug.Log(trans.Position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
