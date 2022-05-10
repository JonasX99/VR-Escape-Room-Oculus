using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using UnityEngine.Events;

public class SocketScript : MonoBehaviour
{
    public string targetName;
    public Transform targetpos;
    public bool MakeChildToTarget;
    public bool DestroySocketObject;

    [SerializeField] private UnityEvent InSocket;
    public void OnTriggerEnter(Collider col){
        if(col.TryGetComponent<GrabInteractable>(out GrabInteractable test) && col.name == targetName){
            //test.enabled = false;
            test.enabled = false;
            test.transform.position = targetpos.position;
            test.transform.rotation = targetpos.rotation;
            InSocket.Invoke();
            if(DestroySocketObject) Destroy(col, 0.1f);
            if(MakeChildToTarget) test.transform.SetParent(targetpos);
        }
    }
}
