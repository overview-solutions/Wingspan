using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OVRTouchSample;
using System;

public class BoxMaker : MonoBehaviour
{
    public GameObject cubePrefab;
    public float minScale = 0.1f;
    public float maxScale = 2f;

    private GameObject currentCube;
    private bool isCreatingCube = false;
    private Vector3 startPosition;
    private Vector3 endPosition;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            startPosition = transform.position;
            isCreatingCube = true;
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            endPosition = transform.position;
            isCreatingCube = false;
            CreateCube();
        }

        if (isCreatingCube)
        {
            endPosition = transform.position;
            UpdateCubeSize();
        }
    }

    void CreateCube()
    {
        float cubeSize = Vector3.Distance(startPosition, endPosition);
        currentCube = Instantiate(cubePrefab, startPosition, Quaternion.identity);
        currentCube.transform.localScale = Vector3.one * cubeSize;
    }

    void UpdateCubeSize()
    {
        float cubeSize = Vector3.Distance(startPosition, endPosition);
        cubeSize = Mathf.Clamp(cubeSize, minScale, maxScale);
        currentCube.transform.localScale = Vector3.one * cubeSize;
    }
}
