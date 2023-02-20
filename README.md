# Wingspan
A LiDAR data environment built for Power Grid modeling and analysis

### Current Progress
![](lidar001.gif)

## Instructions
The [InitSystem.cs](https://github.com/overview-solutions/Wingspan/blob/main/Wingspan/Assets/Scripts/Systems/InitSystem.cs) script is where the LiDAR point cloud is called as a TXT file (from the [StreamingAssets](https://github.com/overview-solutions/Wingspan/tree/main/Wingspan/Assets/StreamingAssets) folder), so this will need to be modified for any new point clouds, including the way each point cloud is centered in the scene.<br>
- [ ] Make a method to auto-center point clouds

### Dependencies
Unity's [ECS](https://unity.com/ecs) (Entity Component System) that is part of their [DOTS](https://unity.com/dots) (Data-Oriented Technology Stack).