using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public static Transform[,] blocks; //2 dimensional array to store set block location
    public GameObject P1I, P1J, P1L, P1O, P1S, P1T, P1Z, P2I, P2J, P2L, P2O, P2S, P2T, P2Z; //tetromino prefabs
    int randomTetromino;
    public static double timer;

    void Start()
    {
        timer = 20;
         QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 20; //sets game frame rate
        P1SpawnTetromino();
        P2SpawnTetromino();
        blocks = new Transform[10,40];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void P1SpawnTetromino()
    {
        randomTetromino = Random.Range(1,8); //Generate random number between 1 and 7

        //spawn random tetromino based on number generated
        switch(randomTetromino)
        {
            case(1):
                Instantiate(P1O, new Vector3((float)-0.5, (float)5.5, 0), Quaternion.identity);
                break;
            case(2):
                Instantiate(P1J, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(3):
                Instantiate(P1L, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(4):
                Instantiate(P1S, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(5):
                Instantiate(P1Z, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(6):
                Instantiate(P1T, new Vector3(0, 5, 0), Quaternion.identity);
                break;
            case(7):
                Instantiate(P1I, new Vector3(0, 5, 0), Quaternion.identity);
                break;
        }
    }

    public void P2SpawnTetromino()
    {
        randomTetromino = Random.Range(1,8); //Generate random number between 1 and 7

        //spawn random tetromino based on number generated
        switch(randomTetromino)
        {
            case(1):
                Instantiate(P2O, new Vector3((float)39.5, (float)5.5, 0), Quaternion.identity);
                break;
            case(2):
                Instantiate(P2J, new Vector3(39, 5, 0), Quaternion.identity);
                break;
            case(3):
                Instantiate(P2L, new Vector3(39, 5, 0), Quaternion.identity);
                break;
            case(4):
                Instantiate(P2S, new Vector3(39, 5, 0), Quaternion.identity);
                break;
            case(5):
                Instantiate(P2Z, new Vector3(39, 5, 0), Quaternion.identity);
                break;
            case(6):
                Instantiate(P2T, new Vector3(39, 5, 0), Quaternion.identity);
                break;
            case(7):
                Instantiate(P2I, new Vector3(39, 5, 0), Quaternion.identity);
                break;
        }
    }

    public bool ClearColumn(int column) //clear complete columns
    {
        if(column >= 0 &&  column <= 39) //only runs on blocks in bounds to avoid errors
        {
            for(int i = 0; i < 10; i++) //check if whole column is complete
            {
                if(blocks[i, column] == null)
                {
                    return false; //leave function if there is no block in any spot in the column
                }
            }

            for(int i = 0; i < 10; i++)
            {
                Destroy(blocks[i, column].gameObject); //destroy the blocks in the completed column
                blocks[i, column] = null;
            }
            return true;
        }
        return false;
    }
}
