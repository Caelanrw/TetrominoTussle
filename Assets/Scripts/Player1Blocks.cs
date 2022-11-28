using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Blocks : MonoBehaviour
{
    public GameObject tetromino; //parent tetromino game object
    public bool active;
    public bool droppable;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(active) //only allows movement for active tetromino
        {
            //movement
            if(Input.GetKeyDown(KeyCode.W)) //move tetromino up
            {
                tetromino.transform.position += new Vector3(0, 1, 0);
            }
            if(Input.GetKeyDown(KeyCode.S)) //move tetromino down
            {
                tetromino.transform.position += new Vector3(0, -1, 0);
            }

            //rotation
            if(Input.GetKeyDown(KeyCode.A)) //rotate tetromino 90 degrees
            {
                tetromino.transform.eulerAngles -= new Vector3(0,0, 90);
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
                    active = false;
                }
            }
        }
    }

    bool DropCheck()
    {
        if(tetromino.transform.position.x != 19.5)
        {
            return true;
        }
        else
        {
            return false;
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