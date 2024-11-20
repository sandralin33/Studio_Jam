using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    public float beatTempo; // bpm 
    public bool predUp; 
    public bool predLeft;
    public bool predRight;
    
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f; // find beats per sec
    }

    // Update is called once per frame
    void Update()
    {
        if(predUp) {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
            }
        
        if(predLeft) {
            transform.position += new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
            }

        if(predRight) {
            transform.position += new Vector3(-beatTempo * Time.deltaTime, 0f, 0f);
            }
    }
}
