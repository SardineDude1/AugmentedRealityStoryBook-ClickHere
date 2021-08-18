using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressScript : MonoBehaviour
{

    public GameObject arCamera;
    public int page=0;
    public AudioSource correct;
    public AudioSource incorrect;

    public GameObject theRightHit;
    public GameObject restartScript;

   public void Press()
    {
        RaycastHit hit;
        if (page > 58)
        {
            restartScript.GetComponent<RestartScript>().CustomButton_onClick();
        }

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.tag == "theOne")
            {
                theRightHit = hit.transform.gameObject;
                correct.GetComponent<AudioSource>().Play(0);
                page += 1;

                GameObject mainscript = GameObject.Find("BookScript");
                BookScript bookScript = mainscript.GetComponent<BookScript>();
                bookScript.PageNumber();

            }
            else
            {
                incorrect.GetComponent<AudioSource>().Play(0);
            }
        }
        else
        {
            incorrect.GetComponent<AudioSource>().Play(0);
        }

    }
}
