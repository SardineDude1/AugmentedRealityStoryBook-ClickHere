using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EighthScript : MonoBehaviour
{
    public Text UIText;
    public GameObject ShakeDetector;

    private GameObject[] spheres;

    public void run()
    {

        spheres = GameObject.FindGameObjectsWithTag("notTheOne");

        foreach (GameObject obj in spheres)
        {
            obj.GetComponent<Rigidbody>().AddRelativeForce(Random.Range(-20.0f, 20.0f), Random.Range(-20.0f, 20.0f), 0.0f);
        }

        UIText.text = "Isn't that something. Maybe a little bit harder this time...";

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
