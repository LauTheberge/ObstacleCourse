using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction("Welcome to the game ! \n Move the character with WASD and avoid the obstacles to reach the end");
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void PrintInstruction(string instruction)
    {
        Debug.Log(instruction);
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
