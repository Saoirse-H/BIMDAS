/*
 * Written by Saoirse Houlihan
 * 17340803
 * https://www.youtube.com/watch?v=zc8ac_qUXQY&ab_channel=Brackeys
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayEasy() {
        SceneManager.LoadScene("AdditionAndSubtraction");
    }

    public void PlayMedium() {
        SceneManager.LoadScene("MultiplicationAndDivision");
    }

    public void PlayHard() {
        SceneManager.LoadScene("Algebra");
    }

    public void QuitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
