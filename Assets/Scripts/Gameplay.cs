using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public static Transform[,] blocks; //2 dimensional array to store set block location
    public GameObject I, J, L, O, S, T, Z; //tetromino prefabs

    void Start()
    {
        Application.targetFrameRate = 20; //sets game frame rate to control drop speed
        SpawnTetromino();
        blocks = new Transform[10,40];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTetromino()
    {
        Instantiate(I, new Vector3(0, 5, 0), Quaternion.identity); //spawn 1 tetromino at point (0,5)
    }
}
