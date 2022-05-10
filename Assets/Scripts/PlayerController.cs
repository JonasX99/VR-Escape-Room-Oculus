using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController playercontroller;
    public OVRCameraRig OVRCameraRig;
    public float gravityValue = -9.81f;
    private Vector3 gravityVelocity;
    private float speed;
    public float walkspeed;
    public float runspeed;
    // Start is called before the first frame update
    void Start()
    {
        playercontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 LThumbstick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick,OVRInput.Controller.LTouch);
        Quaternion headDirection = Quaternion.Euler(0,OVRCameraRig.centerEyeAnchor.eulerAngles.y,0);
        Vector3 Direction = headDirection * new Vector3(LThumbstick.x,0,LThumbstick.y);
        playercontroller.Move(Direction * speed * Time.fixedDeltaTime);

        //Makes the player run when thumbstick is pressed while walking
        if(OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch)) speed = runspeed;
        else speed = walkspeed;
        
        //Changes the CharacterController collider pos and height to match with the headset postion
        playercontroller.center = new Vector3(OVRCameraRig.centerEyeAnchor.localPosition.x,OVRCameraRig.centerEyeAnchor.localPosition.y/2,OVRCameraRig.centerEyeAnchor.localPosition.z);
        playercontroller.height = OVRCameraRig.centerEyeAnchor.localPosition.y;
        
        //Add gravity to the player
        gravityVelocity.y += gravityValue * Time.deltaTime;
        playercontroller.Move(gravityVelocity * Time.deltaTime);
    }
}
