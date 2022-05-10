using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeforeCard : MonoBehaviour
{
    public GameObject AccessCard;
    void OnTriggerEnter(Collider other){
        if(other.name == "Droid"){
            transform.SetParent(other.transform);
            transform.position = new Vector3(other.transform.position.x,other.transform.position.y + other.GetComponent<CharacterController>().height * 2, other.transform.position.z);
        }
        if(other.name == "block"){
            GameObject inst = Instantiate(AccessCard,other.transform.GetChild(0).transform.position,Quaternion.identity);
            inst.name = AccessCard.name;
            Destroy(gameObject);
        }
    }
}
