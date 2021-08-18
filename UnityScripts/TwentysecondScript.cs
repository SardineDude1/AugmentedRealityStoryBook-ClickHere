using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwentysecondScript : MonoBehaviour
{
    public Text UIText;
    private GameObject[] yellowSphere;

    public void run()
    {
        UIText.text = "Let's go out with a bang! Click on it one more time!";

        yellowSphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in yellowSphere)
        {
            obj.gameObject.transform.localScale += new Vector3(1, 1, 1);
        }
    }
}
