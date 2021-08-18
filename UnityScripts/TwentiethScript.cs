using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwentiethScript : MonoBehaviour
{
    public Text UIText;
    public GameObject RotateAround;
    public Vector3 OriginPoint;
    private GameObject[] yellowsphere;

    public void run()
    {
        RotateAround.GetComponent<RotateAround>().isSecond = false;
        RotateAround.GetComponent<RotateAround>().isRotatingReallyFast = false;

        UIText.text = "Whoa, that was close. I think the worst is over. Should we click on the yellow sphere again?";

        yellowsphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in yellowsphere)
        {
            StartCoroutine(MoveOverSeconds(obj, OriginPoint, 5.0f));
        }
    }

    IEnumerator MoveOverSeconds(GameObject objectToMove, Vector3 end, float seconds)
    {
        objectToMove.tag = "notTheOne";
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
        objectToMove.tag = "theOne";
    }
}
