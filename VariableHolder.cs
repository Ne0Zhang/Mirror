using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VariableHolder : MonoBehaviour
{
    float MaxSanity = 20;
    // public Collider MirrorWorld;
    public float CurrentSanity;
    public Text SanityText;
    // Start is called before the first frame update
    void Awake()
    {
        CurrentSanity = MaxSanity;
    }

    // Update is called once per frame
    void Update()
    {
        SanityText.text = CurrentSanity.ToString("F2");
        
        if (CurrentSanity <= 8f) {
            SanityText.GetComponent<Text>().color = Color.red;
        }
        else {
            SanityText.GetComponent<Text>().color = Color.black;
        }
        if (CurrentSanity <= 0) {
            SceneManager.LoadScene("SampleScene");
        }
    }
    
    void OnTriggerStay (Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            remove();
        }
    }

    void OnTriggerExit (Collider other) {
        CurrentSanity = MaxSanity;
    }

    void remove() {
        CurrentSanity -= 0.25f * Time.deltaTime;
    }

    void blink() {

    }
}
