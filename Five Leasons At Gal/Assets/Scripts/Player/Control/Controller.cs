using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Animator Tablet;
    public GameObject cameraController;
    // Start is called before the first frame update
    public GameObject currentCamera;
    public int currentCamState = 0;
    public int camId = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var input = Input.inputString;
        switch (input)
        {
            case "z":
            case "Z":
             
                if(currentCamState == 0)
                {
                    Tablet.Play("TurnOn");
                    StartCoroutine(CamAction());
                    
                }
                else
                {
                    
                    Tablet.Play("TurnOff");
                    StartCoroutine(CamAction());
                    
                }
                
               
              break;
        }
    }
  
     IEnumerator CamAction()
    {
        Debug.Log(currentCamState);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds((float)0.5);
        
        //After we have waited 5 seconds print the time again.
        if(currentCamState == 0)
        {
            Debug.Log("owo");
            cameraController.GetComponent<CameraController>().switchMainCameraToGameCam(currentCamera,camId);
            currentCamState = 1;
        }
        else
        {
            Debug.Log("uwu");
            cameraController.GetComponent<CameraController>().switchGameCameraToMainCam();
            currentCamState = 0;
        }
       
         Tablet.Play("Shhh");
    }
}
