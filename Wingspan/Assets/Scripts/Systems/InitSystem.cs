using System.IO;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace StateMachineValue
{
    [BurstCompile]
    public partial struct InitSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<Config>();
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        }
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            state.Enabled = false;
            var config = SystemAPI.GetSingleton<Config>();
            string filePath = "C:/Users/adam/Documents/GitHub/Wingspan/Wingspan/Builds/Wingspan_Data/StreamingAssets/lidar_data.txt";
            //string filePath = Application.streamingAssetsPath + "/lidar_data.txt";
            string[] lines = File.ReadAllLines(filePath);
            int pointCount = lines.Length/10;

            var cubes = state.EntityManager.Instantiate(config.Prefab,
                (int)(pointCount), Allocator.Temp);
            var center = (pointCount - 1) / 2f;


            Vector3[] positions = new Vector3[pointCount];
            for (int i = 0; i < pointCount; i++)
            {
                var trans = new LocalTransform { Scale = 0.02f };
                string[] values = lines[i].Split(',');
                trans.Position.x = ((float.Parse(values[0]) / 10) - 182600)/10;
                trans.Position.y = (float.Parse(values[2])/10-70)/10;
                trans.Position.z = ((float.Parse(values[1]) / 10) - 71000)/10;
                SystemAPI.SetComponent(cubes[i], trans);
                //Debug.Log(trans.Position);
            }
        }
    }
}