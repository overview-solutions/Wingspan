using System.IO;
using UnityEngine;

class ReadTextFileJob : MonoBehaviour
{
    //static string TestFilename = Path.Combine(Application.streamingAssetsPath, "lidar_data.txt");
    public string lines;
    public async void ReadFile()
    {
        string filePath = Application.streamingAssetsPath + "/lidar_data.txt";
        string lines = File.ReadAllText(filePath);
    }
}
