using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OVRTouchSample;
using System;
using Oculus.Platform.Models;

public class CustomOculusButtons : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //if (OVRInput.Get(OVRInput.RawAxis1D.RHandTrigger) > 0.5f || Input.GetKey("w"))
        //{
            //sundial.now += 512 / (int)mainSlider.value;
            //GetComponent<AudioSource>().Play();
        //}
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstick) || Input.GetKeyDown("r"))
        {
            print("Right Thumb");
        }
        if ((OVRInput.GetDown(OVRInput.RawButton.LThumbstick)) || Input.GetKeyDown("z"))
        {
            print("Left Thumb");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B))
            player.transform.localScale += player.transform.localScale / 4;
        if (OVRInput.GetDown(OVRInput.RawButton.A))
            player.transform.localScale -= player.transform.localScale/5;
    }
}
