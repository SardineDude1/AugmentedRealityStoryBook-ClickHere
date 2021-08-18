using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SixteenthScript : MonoBehaviour
{
    public GameObject RotateScript;
    public Text UIText;

    private GameObject[] BlueSpheres;

    public void run()
    {
        UIText.text = "AHHH! Watchout! It's out of control! Try to pop the blue ones!";

        RotateScript.GetComponent<RotateAround>().isMovingUpAndDown = true;

        BlueSpheres = GameObject.FindGameObjectsWithTag("notTheOne");
        foreach (GameObject sphere in BlueSpheres)
        {
            if (sphere.name == "BlueSphere(Clone)")
            {
                sphere.tag = "theOne";
            }
            else if (sphere.name == "BlueSphere")
            {
                sphere.tag = "theOne";
            }
        }
    }
}
