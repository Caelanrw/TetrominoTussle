using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    public static Transform[,] blocks; //2 dimensional array to store set block location
    public GameObject I, J, L, O, S, T, Z; //tetromino prefabs
    int randomTetromino;
    public static double timer;

    void Start()
    {
        timer = 20;
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
                Instantiate(O, new Vector3((float)0.5, (float)5.5, 0), Quaternion.identity);
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

    public void ClearColumn(int column) //clear complete columns
    {
        for(int i = 0; i < 10; i++) //check if whole column is complete
        {
            if(blocks[i, column] == null)
            {
                return; //leave function if there is no block in any spot in the column
            }
        }

        for(int i = 0; i < 10; i++)
        {
            Destroy(blocks[i, column].gameObject); //destroy the blocks in the completed column

            for(int j = (column - 1); j >= 0; j--) // loops through blocks in columns to left of cleared column
            {
                if(blocks[i, j] != null) //if there is a set block in that space move it to the right
                {
                    blocks[i, j + 1] = blocks[i, j];
                    blocks[i, j + 1].gameObject.transform.position += new Vector3(1, 0, 0);
                    blocks[i, j] = null;
                }

            }
        }
        return;
    }
}
