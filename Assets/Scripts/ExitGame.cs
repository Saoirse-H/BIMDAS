/*
 * Written by Saoirse Houlihan
 * 17340803
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{

    // Update is called once per frame
    void Update() {
       if(Input.GetKey("escape")) {
           Debug.Log("Quit");
           Application.Quit();
       }
    }
}
