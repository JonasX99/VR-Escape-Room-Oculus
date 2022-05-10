using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class EnableDoors : MonoBehaviour
{
    public GrabInteractable Door1;
    public GrabInteractable Door2;

    private bool Door1Open;
    private bool Door2Open;

    public void Door1bool(){
        Door1Open = true;
    }
    
    public void Door2bool(){
        Door2Open = true;
    }
    public void CheckDoorsStatus(){
        if(Door1Open && Door2Open){
            Door1.enabled = true;
            Door2.enabled = true;
        }
    }
}
