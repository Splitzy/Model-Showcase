using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    Animator anim;
    public Animation clip;
    public Animation clip2;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        clip["Door_01"].wrapMode = WrapMode.ClampForever;
        clip2["Door_02"].wrapMode = WrapMode.ClampForever;
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("isOpen", true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag =="Player")
        {
            anim.SetBool("isOpen", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("isOpen", false);
        }
    }
}
