using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class start : MonoBehaviour {


    public GameObject Obj;
    public GameObject Column;
    public GameObject WallZ;
    public GameObject WallX;
    //Object obj;

	// Use this for initialization
	void Start () {
        Debug.Log("start");
        Maze maze = new Maze(101, 101);
        Debug.Log(maze.map);
        for (int i = 0; i <101; i++)
        {
            for (int j=0; j< 101; j++)
            {
                if (maze.map[i, j])
                {
                    if ((i + j) % 2 == 0)
                    {
                        Object obj = new Object(Column, i * 0.5f, 0, j * 0.5f);
                    }
                    else if (i % 2 == 0)
                    {
                        Object obj = new Object(WallZ, i * 0.5f, 0, j * 0.5f);
                    }
                    else
                    {
                        Object obj = new Object(WallX, i * 0.5f, 0, j * 0.5f);
                    }
                    
                }
                    
            }
            
        }
        
	}

    
    /*
	// Update is called once per frame
	void Update () {
        Debug.Log("update");
    }*/
}
