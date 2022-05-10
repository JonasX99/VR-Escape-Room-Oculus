using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droid : MonoBehaviour
{
    private Rigidbody rb;
    public float movelenght;
    public float gravityValue;
    private Vector3 GravityVelocity;
    private Vector2 MoveDirection;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(MoveDirection.x,0, MoveDirection.y);
        controller.Move(movement  * movelenght * Time.fixedDeltaTime);
        GravityVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(GravityVelocity * Time.deltaTime);
    }
    public void TurnDirection(float turn){
        MoveDirection.y = turn;
    }
    public void ForwardDirection(float direction){
        MoveDirection.x = direction;
    }
}
