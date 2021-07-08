/*
 * Written by Saoirse Houlihan
 * 17340803
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {
    AICoLearner aiCoLearner;

    void Start() {
        aiCoLearner = GameObject.Find("Main Camera").GetComponent<AICoLearner>();
    }
    void OnTriggerEnter(Collider player) {
        if(player.gameObject.tag == "Player") {
            aiCoLearner.EndGame();
        }
    } 
}
