/* 
 * Written by Saoirse Houlihan
 * 17340803
 * IEnumerator: https://www.youtube.com/watch?v=ie8IqSUY6Cw&ab_channel=PartumGameTutorials
 * Line 23-27: James Kirwan, UCD Student
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AICoLearner : MonoBehaviour
{
    AudioSource start;
    AudioSource correct;
    AudioSource wrong;
    AudioSource end;

    float duration;
    // Start is called before the first frame update
    void Start() {
        AudioSource[] audio = this.GetComponents<AudioSource>();
        start = audio[0];
        correct = audio[1];
        wrong = audio[2];
        end = audio[3];

        duration = end.clip.length;
        start.Play();
    }

    IEnumerator WaitASecond() {
        end.Play();
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene("StartMenu");

    }

    public void CorrectAnswer() {
        correct.Play();
    }

    public void WrongAnswer() {
        wrong.Play();
    }

    public void EndGame() {
        StartCoroutine(WaitASecond());
    }
}
