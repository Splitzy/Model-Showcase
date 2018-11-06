using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    Animator anim;
    public GameObject OpenPanel;
    public AudioSource sound;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        OpenPanel.SetActive(false);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            OpenPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("isOpen", false);
            OpenPanel.SetActive(false);
        }
    }

    private bool isOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }

    void Update()
    {
        if(isOpenPanelActive)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                sound.Play();
                OpenPanel.SetActive(false);
                anim.SetBool("isOpen", true);
            }
        }
    }
}
