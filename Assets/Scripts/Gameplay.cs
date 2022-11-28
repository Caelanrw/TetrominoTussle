using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public GameObject[,] setBlocks = new GameObject[10,40]; //2 dimensional array to store set block location

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 20; //sets game frame rate to control drop speed
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
