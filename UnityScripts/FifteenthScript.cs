using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifteenthScript : MonoBehaviour
{
    public GameObject RotateScript;
    public Text UIText;
    private GameObject[] BlueSpheres;
    private GameObject[] spheres;

    public void run()
    {
        UIText.text = "Oh No! What have we done?! IDK, maybe shake it again?";

        BlueSpheres = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in BlueSpheres)
        {
            obj.tag = "notTheOne";
        }

        RotateScript.GetComponent<RotateAround>().isRotatingFast = false;
        RotateScript.GetComponent<RotateAround>().isRotatingReallyFast = true;

    }
}
