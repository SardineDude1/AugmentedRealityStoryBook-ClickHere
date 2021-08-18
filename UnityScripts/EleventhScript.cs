using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EleventhScript : MonoBehaviour
{
    public Text UIText;
    public GameObject ShakeDetector;

    private GameObject[] spheres;

    public void run()
    {
        spheres = GameObject.FindGameObjectsWithTag("notTheOne");

        foreach (GameObject obj in spheres)
        {
            obj.GetComponent<Rigidbody>().AddRelativeForce(100.0f, 0.0f, 0.0f);
        }

        UIText.text = "Whoa! A bit too far! Shake your device. Maybe that will help?";

        GameObject pscript = GameObject.Find("PressScript");
        PressScript pressScript = pscript.GetComponent<PressScript>();
        pressScript.page += 1;

        GameObject bscript = GameObject.Find("BookScript");
        BookScript bookScript = bscript.GetComponent<BookScript>();
        bookScript.PageNumber();

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        ShakeDetector.SetActive(false);
        yield return new WaitForSeconds(3);
        ShakeDetector.SetActive(true);
    }
}
