using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    public bool isRotatingSlow = false;
    public bool isRotatingFast = false;
    public bool isRotatingReallyFast = false;
    public bool isMovingUpAndDown = false;
    public GameObject target;
    private GameObject[] spheres;
    private GameObject[] thespheres;
    public bool isFirst = true;
    public bool isSecond = true;

    // Update is called once per frame
    void Update()
    {
        spheres = GameObject.FindGameObjectsWithTag("notTheOne");
        thespheres = GameObject.FindGameObjectsWithTag("theOne");
        if (isRotatingSlow == true)
        {
            foreach (GameObject sphere in spheres)
            {
                sphere.transform.RotateAround(target.transform.position, Vector3.up, 15 * Time.deltaTime);
            }
            foreach (GameObject tsphere in thespheres)
            {
                tsphere.transform.RotateAround(target.transform.position, Vector3.up, 15 * Time.deltaTime);
            }
        }

        else if (isRotatingFast == true)
        {
            foreach (GameObject sphere in spheres)
            {
                sphere.transform.RotateAround(target.transform.position, Vector3.up, 30 * Time.deltaTime);
                
            }
            foreach (GameObject tsphere in thespheres)
            {
                tsphere.transform.RotateAround(target.transform.position, Vector3.up, 30 * Time.deltaTime);
            }
        }

        else if (isRotatingReallyFast == true)
        {
            if (!isMovingUpAndDown)
            {
                foreach (GameObject sphere in spheres)
                {
                    sphere.transform.RotateAround(target.transform.position, Vector3.up, 60 * Time.deltaTime);
                }
                foreach (GameObject tsphere in thespheres)
                {
                    tsphere.transform.RotateAround(target.transform.position, Vector3.up, 60 * Time.deltaTime);
                }
            }
            else if (isMovingUpAndDown)
            {
                foreach (GameObject sphere in spheres)
                {
                    
                    if (sphere.transform.position.y == 0 && isFirst == true)
                    {
                        sphere.GetComponent<Rigidbody>().AddForce(0.0f, 40.0f, 0.0f);
                    }

                    if (sphere.transform.position.y <= 0)
                    {
                        sphere.GetComponent<Rigidbody>().AddForce(0.0f, 40.0f, 0.0f);
                    }
                    else if (sphere.transform.position.y >= 2.0f)
                    {
                        sphere.GetComponent<Rigidbody>().AddForce(0.0f, -40.0f, 0.0f);
                    }
                    sphere.transform.RotateAround(target.transform.position, Vector3.up, 60 * Time.deltaTime);
                }
                isFirst = false;
                foreach (GameObject tsphere in thespheres)
                {
                    
                    if (tsphere.transform.position.y == 0 && isSecond == true)
                    {
                        tsphere.GetComponent<Rigidbody>().AddForce(0.0f, 40.0f, 0.0f);
                    }

                    if (tsphere.transform.position.y <= 0)
                    {
                        tsphere.GetComponent<Rigidbody>().AddForce(0.0f, 40.0f, 0.0f);
                    }
                    else if (tsphere.transform.position.y >= 2.0f)
                    {
                        tsphere.GetComponent<Rigidbody>().AddForce(0.0f, -40.0f, 0.0f);
                    }
                    tsphere.transform.RotateAround(target.transform.position, Vector3.up, 60 * Time.deltaTime);
                }
                isSecond = false;
            }
        }
    }
}
