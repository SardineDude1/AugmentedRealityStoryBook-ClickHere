using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeventhScript : MonoBehaviour
{
    public Text UIText;

    public GameObject BlueSphere;
    private GameObject[] CurrentOneSphere;
    private Transform position;

    public Transform one;
    public Transform two;
    public Transform three;
    public Transform four;

    public void run()
    {
        UIText.text = "That's pretty cool! Try shaking your device... Just a little bit.";

        Instantiate(BlueSphere, one.position, Quaternion.identity);
        Instantiate(BlueSphere, two.position, Quaternion.identity);
        Instantiate(BlueSphere, three.position, Quaternion.identity);
        Instantiate(BlueSphere, four.position, Quaternion.identity);

        CurrentOneSphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in CurrentOneSphere)
        {
            obj.tag = "notTheOne";
        }

        GameObject pscript = GameObject.Find("PressScript");
        PressScript pressScript = pscript.GetComponent<PressScript>();
        pressScript.page += 1;

        GameObject bscript = GameObject.Find("BookScript");
        BookScript bookScript = bscript.GetComponent<BookScript>();
        bookScript.PageNumber();
    }
}
