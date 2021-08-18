using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwelfthScript : MonoBehaviour
{
    public Text UIText;
    public GameObject ShakeDetector;
    public Vector3[] SpawnPoints;
    public int x = 0;

    public Material m;

    private GameObject[] spheres;

    public void run()
    {

        spheres = GameObject.FindGameObjectsWithTag("notTheOne");

        foreach (GameObject obj in spheres)
        {
            StartCoroutine(MoveOverSeconds(obj, SpawnPoints[x], 5f));
            x += 1;
        }

        UIText.text = "Ok. Ok. Interesting. Try clikcing on all the yellow spheres...";

        GameObject pscript = GameObject.Find("PressScript");
        PressScript pressScript = pscript.GetComponent<PressScript>();
        pressScript.page += 1;

        GameObject bscript = GameObject.Find("BookScript");
        BookScript bookScript = bscript.GetComponent<BookScript>();
        bookScript.PageNumber();

        spheres = GameObject.FindGameObjectsWithTag("notTheOne");
        foreach (GameObject obj in spheres)
        {
            if (obj.name == "YellowSphere")
            {
                obj.tag = "theOne";
            }
            if (obj.name == "YellowSphere(Clone)")
            {
                obj.tag = "theOne";
            }
        }
        
    }

    IEnumerator MoveOverSeconds(GameObject objectToMove, Vector3 end, float seconds)
    {
        float elapsedTime = 0;
        Vector3 startingPos = objectToMove.transform.position;
        while (elapsedTime < seconds)
        {
            objectToMove.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        objectToMove.transform.position = end;
        objectToMove.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}