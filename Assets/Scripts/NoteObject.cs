using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed; 
    public bool dead; 
    [SerializeField] KeyCode keyToPress; // find what key to press

    public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress)) {
            if(canBePressed) {
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();
                Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
                // SFX.Play();
            }
        }

        if(dead) {
            GameManager.instance.NoteMissed();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) { // checks if within hit box
        if(other.tag == "Activator") {
            canBePressed = true; 
        }

        if(other.tag == "Miss Zone") {
            dead = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Activator") {
            canBePressed = false;
            }
    }
}
