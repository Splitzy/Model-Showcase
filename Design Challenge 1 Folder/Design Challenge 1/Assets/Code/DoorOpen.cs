using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    Animator anim;
    public bool doorOpen = false;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown("e"))
        {
            OpenDoor();
        }
	}

    void OpenDoor()
    {
        if (doorOpen == true)
        {
            //anim.Play();
            doorOpen = false;
        }
        else
        {
            //anim.Play();
            doorOpen = true;
        }
    }
}
