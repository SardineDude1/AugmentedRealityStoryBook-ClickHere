using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EighteenthScript : MonoBehaviour
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
            UIText.text = "Ok Ok. I feel good about this. Try to pop the red spheres now.";

            spheres = GameObject.FindGameObjectsWithTag("notTheOne");
            foreach (GameObject obj in spheres)
            {
                if (obj.name == "RedSphere(Clone)")
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
