using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public static Transform[,] blocks; //2 dimensional array to store set block location
    public GameObject P1I, P1J, P1L, P1O, P1S, P1T, P1Z, P2I, P2J, P2L, P2O, P2S, P2T, P2Z; //tetromino prefabs 
    int randomTetromino; //stores number for random tetromino spawn
    public static double timer; //shared automatic drop timer

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 20; //sets game frame rate to 20 fps
        timer = 20; //initially tetrominoes will drop at 1 block per second
        P1SpawnTetromino(); //spawns first tetrominoes
        P2SpawnTetromino();
        blocks = new Transform[10,40]; //array of blocks the same size as playfield
    }

    public void P1SpawnTetromino()
    {
        randomTetromino = Random.Range(1,8); //Generate random number between 1 and 7

        //spawn random player 1 tetromino based on number generated
        switch(randomTetromino)
        {
            case(1):
                Instantiate(P1O, new Vector3((float)-0.5, (float)5.5, 0), Quaternion.identity); //the O tetromino is centered differently
                break;
            case(2):
                Instantiate(P1J, new Vector3(0, 5, 0), Quaternion.identity); //spawn at location (0, 5)
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

        //spawn random player 2 tetromino based on number generated
        switch(randomTetromino)
        {
            case(1):
                Instantiate(P2O, new Vector3((float)39.5, (float)5.5, 0), Quaternion.identity);
                break;
            case(2):
                Instantiate(P2J, new Vector3(39, 5, 0), Quaternion.identity); //spawn at (39,5)
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
                if(blocks[i, column] == null) //leave function if there is no block in any spot in the column
                {
                    return false; 
                }
            }

            for(int i = 0; i < 10; i++)
            {
                Destroy(blocks[i, column].gameObject); //destroy the blocks in the completed column
                blocks[i, column] = null; //set those deleted spots to null
            }
            return true; //return true if a column was cleared
        }
        return false; //return false if a column was not cleared
    }
}
