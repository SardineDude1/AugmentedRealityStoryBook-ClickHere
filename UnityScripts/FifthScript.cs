using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifthScript : MonoBehaviour
{
    public Text UIText;

    public GameObject YellowSphere;
    private GameObject[] CurrentOneSphere;
    private Transform position;

    public Transform positionOfNewTheOne;
    private GameObject[] objs;

    public Transform one;
    public Transform two;
    public Transform three;
    public Transform four;

    public void run()
    {
        UIText.text = "And now five on the red...";

        Instantiate(YellowSphere, one.position, Quaternion.identity);
        Instantiate(YellowSphere, two.position, Quaternion.identity);
        Instantiate(YellowSphere, three.position, Quaternion.identity);
        Instantiate(YellowSphere, four.position, Quaternion.identity);

        CurrentOneSphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in CurrentOneSphere)
        {
            obj.tag = "notTheOne";
        }

        objs = GameObject.FindGameObjectsWithTag("notTheOne");
        foreach (GameObject o in objs)
        {
            if (o.transform.position == positionOfNewTheOne.position)
            {
                o.tag = "theOne";
            }
        }
    }
}
