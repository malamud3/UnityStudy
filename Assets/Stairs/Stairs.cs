using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairs : MonoBehaviour
{
    private Animator animator;
    private AudioSource Audio;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();

    }


}
