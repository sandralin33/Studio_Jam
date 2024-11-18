using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo; // bpm 

    public bool start; // start game when any key pressed
    
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f; // find beats per sec
    }

    // Update is called once per frame
    void Update()
    {
        if (!start) {
            // if (Input.GetKeyDown("space")) {
            //     hasStarted = true;
            // }
        } 
        else {
            transform.position += new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
        }
    }
}
