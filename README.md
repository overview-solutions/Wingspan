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
![](/Notes/RenderProfileCompFinal02.png)

### 02/25/2023 - Testing Notes
Based on this example, Sprites are useful for regular GameObjet rendering, as well as Particle System rendering, although Cubes seem to outperform Sprites when using the ECS.