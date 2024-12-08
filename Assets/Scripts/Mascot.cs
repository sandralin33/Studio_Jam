using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Events;

public class Mascot : MonoBehaviour
{
    public Animator anim;
    // public UnityEvent hit;
    public static Mascot axo;

    // Start is called before the first frame update
    void Start()
    {
        axo = this;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("onhit");
            Debug.Log("up key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("punch");
            Debug.Log("left key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("right");
            Debug.Log("right key was pressed");
        }

    }
}