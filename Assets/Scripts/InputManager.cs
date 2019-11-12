using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum MoveDirection
{
    Left, Right, Up, Down
}

public class InputManager : MonoBehaviour
{
    private MyGameManager _gameManager;

    private void Awake()
    {
        _gameManager = GameObject.FindObjectOfType<MyGameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _gameManager.Move(MoveDirection.Right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _gameManager.Move(MoveDirection.Left);
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            _gameManager.Move(MoveDirection.Up);
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _gameManager.Move(MoveDirection.Down);
        }
    }
}
