/*
 * Written by Saoirse Houlihan
 * 17340803
 * https://www.youtube.com/watch?v=KPdP3CdzUmk&ab_channel=PaulConway
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycasting : MonoBehaviour {
    public float distance;
    RaycastHit hitObject;
    GameObject pickedUpCube;
    Transform onHand;

    // Start is called before the first frame update
    void Start() {
        onHand = GameObject.Find("onHand").transform;
    }

    // Update is called once per frame
    void Update() {
        Debug.DrawRay(this.transform.position, this.transform.forward * distance, Color.magenta);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out hitObject, distance)) {
            if(Input.GetMouseButtonDown(0)) {
                if(hitObject.collider.gameObject != null) {
                    pickedUpCube = hitObject.collider.gameObject;
                    pickUp();
                }
            }

            if(Input.GetMouseButtonUp(0)) {
                putDown();
                pickedUpCube = null;
            }
        }
    }

    void pickUp() {
        if(pickedUpCube.tag == "key") {
            pickedUpCube.GetComponent<Rigidbody>().useGravity = false;
            pickedUpCube.GetComponent<Rigidbody>().freezeRotation = true;
            pickedUpCube.transform.position = onHand.position;
            pickedUpCube.transform.parent = GameObject.Find("onHand").transform;        
        }
    }

    void putDown() {
        if(pickedUpCube != null && pickedUpCube.tag == "key") {
            pickedUpCube.gameObject.transform.parent = null;
            pickedUpCube.gameObject.GetComponent<Rigidbody>().freezeRotation = false;
            pickedUpCube.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
