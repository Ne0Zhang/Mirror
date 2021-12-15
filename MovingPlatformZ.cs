using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformZ : MonoBehaviour
{
    public float sec0, sec1, sec2;
    public float distance;
    private float MAX, MIN;
    private float speed = 2.5f;
    private bool state = true;
    bool pause = true;

    void Start() {
        StartCoroutine(coroutineB(sec0));
        MIN = transform.position.z + distance;
        MAX = transform.position.z;
    }
    void Update() {
        if (!pause && state)
            Move1();
        else if (!pause && !state)
            Move2();
    }

    void Move1() {
        //MAX = -5 and current is 0
        if (transform.position.z >= MIN) {
            transform.Translate(new Vector3(0, 0, -1) * (speed * Time.deltaTime));
            return;
        } else {
            StartCoroutine(coroutineA(sec1));
        }
    }

    void Move2() {
        //MAX = -5 and current is 0
        if (transform.position.z <= MAX) {
            transform.Translate(new Vector3(0, 0, 1) * (speed * Time.deltaTime));
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
