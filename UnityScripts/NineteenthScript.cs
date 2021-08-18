using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NineteenthScript : MonoBehaviour
{
    public Text UIText;
    public GameObject PScript;
    public GameObject bsphere;
    public AudioSource pop;
    private GameObject[] spheres;
    private bool isFirst = true;

    public void run()
    {
        if (isFirst)
        {
            UIText.text = "Whew! It seems to be working. Pop the yellow ones.";

            spheres = GameObject.FindGameObjectsWithTag("notTheOne");
            foreach (GameObject obj in spheres)
            {
                if (obj.name == "YellowSphere(Clone)")
                {
                    obj.tag = "theOne";
                }

                else if (obj.name == "YellowSphere")
                {
                    obj.tag = "theOne";
                }
            }
            isFirst = false;
        }

        pop.Play();
        bsphere = PScript.GetComponent<PressScript>().theRightHit;
        Destroy(bsphere);
    }
}