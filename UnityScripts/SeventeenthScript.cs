using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeventeenthScript : MonoBehaviour
{
    public GameObject PScript;
    public GameObject bsphere;
    public AudioSource pop;

    public void run()
    {
        pop.Play();
        bsphere = PScript.GetComponent<PressScript>().theRightHit;
        Destroy(bsphere);
    }
}
