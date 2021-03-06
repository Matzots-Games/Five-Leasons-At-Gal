﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    public GameObject[] gameCams;
    // Start is called before the first frame update
    public GameObject currentCam;
    private int camId;
   
    public GameObject Player;
    void Awake()
    {
       
        gameCams = GetComponent<GameManager>().GetCameras();
        for (int i = 0; i < gameCams.Length; i++)
        {
            if(gameCams[i].name == currentCam.name)
            {
                camId = i;
            }
            gameCams[i].GetComponent<Camera>().enabled = false;
        }
    }
    public void switchMainCameraToGameCam(GameObject cameraToDisable,int camIdToEnable)
    {
            cameraToDisable.GetComponent<Camera>().enabled = false;
            Player = cameraToDisable;
            gameCams[camIdToEnable].GetComponent<Camera>().enabled = true;
            camId = camIdToEnable;
            
    }
    public void switchGameCameraToMainCam()
    {
            Player.GetComponent<Camera>().enabled = true;
           
            gameCams[camId].GetComponent<Camera>().enabled = false;
            Player.GetComponent<Controller>().camId = camId;
            
    }
    // Update is called once per frame
    void Update()
    {
        var input = Input.inputString;

        switch (input)
        {
            default:
                Debug.Log(camId);
                break;
            case "d":
            case "D":
                if (camId < gameCams.Length - 1)
                {
                    gameCams[camId].GetComponent<Camera>().enabled = false;
                    gameCams[camId + 1].GetComponent<Camera>().enabled = true;
                    camId += 1;
                    Debug.Log("right");
                    
                }
                break;
            case "a":
            case "A":

                if (camId > 0)
                {
                    gameCams[camId].GetComponent<Camera>().enabled = false;
                    gameCams[camId - 1].GetComponent<Camera>().enabled = true;
                    camId -= 1;
                    Debug.Log("left");
                    
                }
                break;
            case "z":
            case "Z":
                switchGameCameraToMainCam();
                break;
        }
       
       
    }
}
