using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to Oopstacles");
        Debug.Log("The objective of the game is to help Bouncy-The Ball reach the exit of the maze");
        Debug.Log("You can control movements of Bouncy using WASD and arrow keys");
        Debug.Log("Dont hit the walls and other obstacles");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(xValue,0,zValue);
    }
}
