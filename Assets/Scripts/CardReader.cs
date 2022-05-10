using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class CardReader : MonoBehaviour
{
    public GrabInteractable EnableTarget;
    public Material gree;
    void OnTriggerEnter(Collider other){
        if(other.name == "Card"){
            transform.Find("Red").GetComponent<MeshRenderer>().material = gree;
            EnableTarget.enabled = true;
        }
    }
}
