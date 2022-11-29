using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Blocks : MonoBehaviour
{
    public GameObject tetromino; //parent tetromino game object
    bool active, droppable, movable, rotatable;
    Gameplay gameControl;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
        gameControl = FindObjectOfType<Gameplay>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if(active) //only allows movement for active tetromino
        {
            //movement
            if(Input.GetKeyDown(KeyCode.W)) //move tetromino up
            {
                movable = MovementCheckUp();

                if(movable)
                {
                    tetromino.transform.position += new Vector3(0, 1, 0);
                }

            }
            if(Input.GetKeyDown(KeyCode.S)) //move tetromino down
            {
                movable = MovementCheckDown();

                if(movable)
                {
                    tetromino.transform.position += new Vector3(0, -1, 0);
                }
            }

            //rotation
            if(Input.GetKeyDown(KeyCode.A)) //rotate tetromino 90 degrees
            {
                tetromino.transform.eulerAngles -= new Vector3(0, 0, 90);

                foreach(Transform block in tetromino.transform) //accounts for small rounding errors from rotations
                {
                    block.transform.position = new Vector3(Mathf.Round(block.transform.position.x), Mathf.Round(block.transform.position.y), 0);
                }
            }

            //dropping
            
            if(Input.GetKey(KeyCode.D)) //fast drop
            {
                droppable = DropCheck();
                
                if(droppable)
                {
                    tetromino.transform.position += new Vector3(1, 0, 0);
                }
                else
                {
                    active = false; //if not droppable it sets
                    SetBlocks();
                    gameControl.SpawnTetromino();
                }
            }
        }
    }

    bool DropCheck() //checks if it possible for the tetromino to continue dropping
    {
        foreach(Transform block in tetromino.transform)
        {
            if(Mathf.Round(block.transform.position.x) == 19) //can't drop if block is at the divider
            {
                return false;
            }
            else if(Gameplay.blocks[(int)block.transform.position.y, (int)block.transform.position.x + 1] != null) //can't drop if there is a set block in the way
            {
                return false;
            }
        }

        return true;
    }

    bool MovementCheckUp()
    {
        foreach(Transform block in tetromino.transform)
        {
            if(Mathf.Round(block.transform.position.y) == 9)
            {
                return false;
            }
            else if(Gameplay.blocks[(int)block.transform.position.y + 1, (int)block.transform.position.x] != null)
            {
                return false;
            }
        }

        return true;
    }

    bool MovementCheckDown()
    {
        foreach(Transform block in tetromino.transform)
        {
            if(Mathf.Round(block.transform.position.y) == 0)
            {
                return false;
            }
            else if(Gameplay.blocks[(int)block.transform.position.y - 1, (int)block.transform.position.x] != null)
            {
                return false;
            }
        }

        return true;
    }

    void SetBlocks()
    {
        foreach(Transform block in tetromino.transform)
        {
            Gameplay.blocks[(int)block.transform.position.y, (int)block.transform.position.x] = block;
        }
    }

   /* void DestroyChildren() //Not functional just reference/test code
    {
        foreach(Transform block in tetromino.transform)
        {
            Destroy(block.gameObject);
        }
    }*/
}