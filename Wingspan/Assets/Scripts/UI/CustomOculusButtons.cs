using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OVRTouchSample;
using System;

public class CustomOculusButtons : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
            player.transform.localScale += player.transform.localScale / 4;
        if (OVRInput.GetDown(OVRInput.RawButton.A))
            player.transform.localScale -= player.transform.localScale/5;
    }
}
