using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] gameCams;
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }
    public void Init()
    {
        GetCameras();
    }
    public GameObject[] GetCameras()
    {

       
        gameCams = GameObject.FindGameObjectsWithTag("GameCam");
        // Sort That Array PLS its 1 am
        //int counter = 1;
        //while (counter != 0)
        //{
        //    for (int i = 1; i < gameCams.Length; i++)
        //    {
                
        //        if ((int)gameCams[i].name[0] > (int)gameCams[i - 1].name[0])
        //        {
        //            counter++;
        //            GameObject temp = gameCams[i];
        //            gameCams[i] = gameCams[i - 1];
        //            gameCams[i - 1] = temp;
        //        }
        //    }
        //    counter = 0;
        //}
       
        return gameCams;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
