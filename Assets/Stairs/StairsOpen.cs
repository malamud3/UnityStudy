using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsOpen : MonoBehaviour
{
    private Animator animator;
    private AudioSource Audio;

   //  public GameObject stairPrefab;
   //  public GameObject stairs;
  //   bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();

      //    if (stairs == null)
      //       stairs = GameObject.FindWithTag("stairs");

    }



    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("open", true);
        Audio.PlayDelayed(1.5f);


      //    if(flag==true)
//             {
//
 //              stairs.GetComponent<Animation>().Play();
 //         }



    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("open", false);
       
    }
}
