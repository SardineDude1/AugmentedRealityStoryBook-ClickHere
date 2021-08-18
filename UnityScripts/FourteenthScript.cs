using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourteenthScript : MonoBehaviour
{
    public GameObject RotateScript;
    public Text UIText;
    private GameObject[] RedSpheres;
    private GameObject[] spheres;

    public void run()
    {
        UIText.text = "Well, that's troubling. Maybe try clicking on the blue ones?";

        RedSpheres = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in RedSpheres)
        {
            obj.tag = "notTheOne";
        }

        RotateScript.GetComponent<RotateAround>().isRotatingSlow = false;
        RotateScript.GetComponent<RotateAround>().isRotatingFast = true;

        spheres = GameObject.FindGameObjectsWithTag("notTheOne");
        foreach (GameObject obj in spheres)
        {
            if (obj.name == "BlueSphere")
            {
                obj.tag = "theOne";
            }
            if (obj.name == "BlueSphere(Clone)")
            {
                obj.tag = "theOne";
            }
        }
    }
}
