using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Blocks : MonoBehaviour
{
    public GameObject tetromino;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            tetromino.transform.position += new Vector3(0, 1, 0);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            tetromino.transform.position += new Vector3(0, -1, 0);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            tetromino.transform.eulerAngles -= new Vector3(0,0, 90);
        }
    }
    void DestroyChildren()
    {
        foreach(Transform block in tetromino.transform)
        {
            Destroy(block.gameObject);
        }
    }
}