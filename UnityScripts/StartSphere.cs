using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSphere : MonoBehaviour
{
    public GameObject[] StartingSpheres;
    public GameObject center;

    // Start is called before the first frame update
    void Start()
    {
        StartingSpheres = GameObject.FindGameObjectsWithTag("Starting");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject obj in StartingSpheres)
        {
            obj.transform.RotateAround(center.transform.position, Vector3.forward, 100 * Time.deltaTime);
        }
    }
}
