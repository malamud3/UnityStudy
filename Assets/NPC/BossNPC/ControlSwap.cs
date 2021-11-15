using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSwap : MonoBehaviour
{
    private Animator animator;
    private AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();

    }



    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("point", true);
        Audio.PlayDelayed(1.5f);

    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("point", false);
    }
}
