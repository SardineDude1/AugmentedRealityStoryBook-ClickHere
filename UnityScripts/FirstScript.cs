using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstScript : MonoBehaviour
{
    public Text UIText;
    public GameObject YellowSphere;
    public Transform spawnYellow;

    public void run()
    {
        UIText.text = "Great! Now click the center yellow sphere again.";
        Instantiate(YellowSphere, spawnYellow.position, Quaternion.identity);
    }
}
