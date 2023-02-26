# Wingspan
A LiDAR data environment built for Power Grid modeling and analysis

### Current Progress
![](lidar001.gif)

## Instructions
The [InitSystem.cs](https://github.com/overview-solutions/Wingspan/blob/main/Wingspan/Assets/Scripts/Systems/InitSystem.cs) script is where the LiDAR point cloud is called as a TXT file (from the [StreamingAssets](https://github.com/overview-solutions/Wingspan/tree/main/Wingspan/Assets/StreamingAssets) folder), so this will need to be modified for any new point clouds, including the way each point cloud is centered in the scene.<br>

- [ ] Make a method to auto-center point clouds
- [ ] Get it working in VR
- [ ] Test performance against regular Unity scene

### Dependencies
Unity's [ECS](https://unity.com/ecs) (Entity Component System) that is part of their [DOTS](https://unity.com/dots) (Data-Oriented Technology Stack).

## Rendering Optimization Notes
Within the Unity GameEngine there are several pipelines and workflows designed to optimize various graphical effects and behaviors. Some are designed to reduce the amount of data that is attached directly to each GameObject, while others find ways to reduce the graphical complexity of each GameObject in the scene. Below is the testing that was done to determine the initial workflow for rendering point clouds.
![](/Notes/RenderProfileCompFinal.png)

### 02/25/2023 - Testing Notes
Particle System v ECS

Vanilla
Particle
ECS

Vanilla
- Sprites:  00:40
- Planes:   00:50   00:45
- Cubes:    00:52   00:45

Particle
- Sprites   00:15   00:56
- Planes    01:02   00:52
- Cubes     00:50   00:44

ECS
- Sprite    00:42   01:08
- Plane     00:16   00:12
- Cube      00:08