using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mascot : MonoBehaviour
{
    
    public Animator animator;

    // private bool Headbutt = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // if (Headbutt)
            // return;
            
            // GetComponent<Animator>().SetTrigger("Headbutt");
            // Headbutt = true;

            Debug.Log("space key was pressed");
        }
    }
}