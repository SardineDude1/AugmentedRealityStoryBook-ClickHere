using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwentythirdScript : MonoBehaviour
{
    public AudioSource pop;
    public AudioSource Tada;
    private GameObject[] yellowSphere;
    public Text UIText;
    public Text ClickText;
    public GameObject bookscript;

    public void run()
    {
        pop.Play();
        yellowSphere = GameObject.FindGameObjectsWithTag("theOne");
        foreach (GameObject obj in yellowSphere)
        {
            Destroy(obj);
        }
        UIText.text = "Yay! You made it to the end! Congratulations!";
        ClickText.text = "Restart";
        bookscript.GetComponent<PressScript>().page++;
        StartCoroutine(tada());
    }

    private IEnumerator tada()
    {
        yield return new WaitForSeconds(0.5f);
        Tada.Play();
    }
}
