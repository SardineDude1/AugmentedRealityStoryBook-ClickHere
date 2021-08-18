using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdScript : MonoBehaviour
{
    public Text UIText;

    public GameObject RedSphere;
    private GameObject[] CurrentOneSphere;
    public Transform positionOfNewTheOne;
    private GameObject[] objs;
    private Transform position;

    public void run()
    {
        UIText.text = "Well Done! Now the one on the right...";

        CurrentOneSphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in CurrentOneSphere)
        {
            position = obj.transform;
            Destroy(obj);
            Instantiate(RedSphere, position.position, Quaternion.identity);
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
