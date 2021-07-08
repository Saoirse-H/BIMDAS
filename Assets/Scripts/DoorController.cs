/*
 * Written by Saoirse Houlihan
 * 17340803
 * Line 29: bigmisterb https://forum.unity.com/threads/door-open-close-in-c.410811/
 * OnCollisionEnter: https://www.youtube.com/watch?v=doNywPp0Mnw&t=1s&ab_channel=PaulConway
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    public GameObject doorOpen;
    public bool isOpened = false;
    public float moveSpeed = 3;
    Value.Values answer;
    GameObject previousCollidedCube;
    AICoLearner aiCoLearner;
    // Start is called before the first frame update
    void Start() {
        doorOpen.SetActive(false);
        answer = this.GetComponent<Value>().value;
        previousCollidedCube = null;
        aiCoLearner = GameObject.Find("Main Camera").GetComponent<AICoLearner>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if(isOpened) {
            this.transform.position = Vector3.MoveTowards(this.transform.position, doorOpen.transform.position, moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision cube) {
        if(cube.gameObject.tag == "key") {
            if(cube.gameObject != previousCollidedCube) {
                previousCollidedCube = cube.gameObject;

                if(cube.gameObject.GetComponent<Value>().value == answer) {
                    aiCoLearner.CorrectAnswer();
                    isOpened = true;
                    Destroy(cube.gameObject);
                } else {
                    aiCoLearner.WrongAnswer();
                }
            }

            
        }
    }
}
