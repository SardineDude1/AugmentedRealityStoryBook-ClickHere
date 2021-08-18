using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwentyfirstScript : MonoBehaviour
{
    public Text UIText;
    private GameObject[] yellowSphere;

    public void run()
    {
        UIText.text = "It got bigger. That's cool. You should click on it again.";

        yellowSphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in yellowSphere)
        {
            obj.gameObject.transform.localScale += new Vector3(1, 1, 1);
        }
    }

}
