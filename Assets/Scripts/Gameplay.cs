using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public static Transform[,] blocks; //2 dimensional array to store set block location
    public GameObject I, J, L, O, S, T, Z; //tetromino prefabs
    int randomTetromino;

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
        randomTetromino = Random.Range(1,8); //Generate random number between 1 and 7

        //spawn random tetromino based on number generated
        switch(randomTetromino)
        {
            case(1):
                Instantiate(O, new Vector3((float)0.5, 5, 0), Quaternion.identity);
                break;
            case(2):
                Instantiate(J, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(3):
                Instantiate(L, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(4):
                Instantiate(S, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(5):
                Instantiate(Z, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(6):
                Instantiate(T, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(7):
                Instantiate(I, new Vector3(0, 5, 0), Quaternion.identity);
                break;
        }
    }
}
