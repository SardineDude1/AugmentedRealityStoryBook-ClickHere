using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondScript : MonoBehaviour
{
    public Text UIText;
    public GameObject YellowSphere;
    private GameObject[] CurrentOneYellowSphere;
    public Transform spawnYellow;

    public Transform positionOfNewTheOne;
    private GameObject[] objs;

    public void run()
    {
        // Change the instructions presented to the user.
        UIText.text = "Perfect. Click on the sphere to the left...";

        // Make a new Sphere.
        Instantiate(YellowSphere, spawnYellow.position, Quaternion.identity);

        // Find the current sphere with the tag theOne and change it to notTheOne.
        CurrentOneYellowSphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach(GameObject obj in CurrentOneYellowSphere)
        {
            obj.tag = "notTheOne";
        }

        objs = GameObject.FindGameObjectsWithTag("notTheOne");
        foreach(GameObject o in objs)
        {
            if (o.transform.position == positionOfNewTheOne.position)
            {
                o.tag = "theOne";
            }
        }

    }
}
