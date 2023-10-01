using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTrigger: MonoBehaviour {
    
 void OnTriggerEnter(Collider collisionInfo){
      if(collisionInfo.gameObject.tag == "Player")
        collisionInfo.gameObject.GetComponent<Renderer>().material.color=Color.green;
 }

 void OnTriggerStay(Collider collisionInfo){
    if(collisionInfo.gameObject.tag == "Player")
      collisionInfo.gameObject.GetComponent<Renderer>().material.color=Color.red;
 }

 void OnTriggerExit(Collider collisionInfo){
    if(collisionInfo.gameObject.tag == "Player")
      collisionInfo.gameObject.GetComponent<Renderer>().material.color=Color.blue;
 }


}