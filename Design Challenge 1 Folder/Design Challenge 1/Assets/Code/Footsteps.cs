using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource step;


    void Update()
    {
        if(Input.GetAxis("Vertical") > 0 && !step.isPlaying)
        {
            step.volume = Random.Range(0.8f, 1f);
            step.pitch = Random.Range(0.7f, 1f);
            step.Play();
        }
    }

}
