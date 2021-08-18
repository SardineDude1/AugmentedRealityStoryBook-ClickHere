using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirteenthScript : MonoBehaviour
{
    public Text UIText;
    private GameObject[] spheres;
    private GameObject[] yellow_spheres;
    public GameObject RotateScript;

    public void run()
    {
        UIText.text = "Huh, that's weird. Try clicking on the red spheres...";

        yellow_spheres = GameObject.FindGameObjectsWithTag("theOne");
        foreach(GameObject obj in yellow_spheres)
        {
            obj.tag = "notTheOne";
        }

        RotateScript.GetComponent<RotateAround>().isRotatingSlow = true;

        spheres = GameObject.FindGameObjectsWithTag("notTheOne");
        foreach (GameObject obj in spheres)
        {
            if (obj.name == "RedSphere")
            {
                obj.tag = "theOne";
            }
            if (obj.name == "RedSphere(Clone)")
            {
                obj.tag = "theOne";
            }
        }
    }
    
}
