using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformY : MonoBehaviour
{
    public float sec0, sec1, sec2;
    public float distance;
    private float MAX, MIN;
    private float speed = 2.5f;
    private bool state = true;
    bool pause = true;

    void Start() {
        StartCoroutine(coroutineB(sec0));
        MAX = transform.position.y + distance;
        MIN = transform.position.y;
    }
    void Update() {
        if (!pause && state)
            Move1();
        else if (!pause && !state)
            Move2();
    }

    void Move1() {
        //MAX = -5 and current is 0
        if (transform.position.y <= MAX) {
            transform.Translate(new Vector3(0, 1, 0) * (speed * Time.deltaTime));
            return;
        } else {
            StartCoroutine(coroutineA(sec1));
        }
    }

    void Move2() {
        //MAX = -5 and current is 0
        if (transform.position.y >= MIN) {
            transform.Translate(new Vector3(0, -1, 0) * (speed * Time.deltaTime));
            return;
        } else {
            StartCoroutine(coroutineA(sec2));
        }
    }

    IEnumerator coroutineA(float second) {
        // Debug.Log("CoroutineA Created: " + second);
        pause = !pause;
        yield return new WaitForSeconds(second);
        state = !state;
        pause = !pause;
        // Debug.Log("CoroutineA Finished");
    }

    IEnumerator coroutineB(float second) {
        yield return new WaitForSeconds(second);
        pause = !pause;
    }
}
