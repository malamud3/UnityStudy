using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwap : MonoBehaviour
{
    Animator animator;
    private AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Flag", true);
        Audio.PlayDelayed(0.5f);

    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Flag", false);

    }
}
