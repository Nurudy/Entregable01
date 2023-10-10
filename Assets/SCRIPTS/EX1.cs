using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 Position;
    private Vector3 Direction;
    
    public float MoveTimer;
    public float MoveTimerMax = 0.5f; //movement from point to point every 0.5 seconds.

    private void Awake()
    {
        startPosition = new Vector3(0, 0, 0);
        Position = startPosition;

        Direction = new Vector3(0, 0, 1); //FROG DIRECTION
    }

    private void Update() //executed everytime
    {
        FrogDirection();
        FrogMovement();

    }

    private void FrogMovement()
    {
        MoveTimer += Time.deltaTime;
        if (MoveTimer >= MoveTimerMax)
        {
            Position += Direction;
            MoveTimer -= MoveTimerMax;
        }

        transform.position = new Vector3(0, 0, 1);
    }

    private void FrogDirection()
    {

    
    }


}
