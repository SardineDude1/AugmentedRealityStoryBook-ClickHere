using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinethScript : MonoBehaviour
{
    public Text UIText;
    public GameObject ShakeDetector;

    private GameObject[] spheres;

    public void run()
    {

        spheres = GameObject.FindGameObjectsWithTag("notTheOne");

        foreach (GameObject obj in spheres)
        {
            obj.GetComponent<Rigidbody>().AddRelativeForce(Random.Range(-40.0f, 40.0f), Random.Range(-40.0f, 40.0f), 0.0f);
        }

        UIText.text = "Well done! Now tilt the screen to the left.";

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
