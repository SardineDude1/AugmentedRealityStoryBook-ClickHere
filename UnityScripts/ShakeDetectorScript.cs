using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeDetectorScript : MonoBehaviour
{

    public float ShakeDetectionThreshold1;
    public float ShakeDetectionThreshold2;
    public float TiltDetectionThreshold1;

    public GameObject BookScript;
    public GameObject EighthPage;
    public GameObject NinthPage;
    public GameObject TenthPage;
    public GameObject EleventhPage;
    public GameObject TwelfthPage;
    public GameObject SixteenthPage;

    public AudioSource correct;

    private float sqrShakeDetectionThreshold1;
    private float sqrShakeDetectionThreshold2;
    private float sqrTiltDetectionThreshold1;


    // Start is called before the first frame update
    void Start()
    {
       
        sqrShakeDetectionThreshold1 = Mathf.Pow(ShakeDetectionThreshold1, 2);
        sqrShakeDetectionThreshold2 = Mathf.Pow(ShakeDetectionThreshold2, 2);
        sqrTiltDetectionThreshold1 = Mathf.Pow(TiltDetectionThreshold1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.acceleration.sqrMagnitude >= sqrTiltDetectionThreshold1 && BookScript.GetComponent<BookScript>().pageNumber == 23)
        {
            Vector3 tilt = Vector3.zero;
            tilt.x = Input.acceleration.x;
            if (Mathf.Pow(tilt.x, 2) > sqrTiltDetectionThreshold1)
            {
                correct.GetComponent<AudioSource>().Play(0);
                EleventhPage.GetComponent<EleventhScript>().run();
            }
        }

        else if (Input.acceleration.sqrMagnitude >= sqrTiltDetectionThreshold1 && BookScript.GetComponent<BookScript>().pageNumber == 22)
        {
            Vector3 tilt = Vector3.zero;
            tilt.x = Input.acceleration.x;
            if (Mathf.Pow(tilt.x, 2) > sqrTiltDetectionThreshold1)
            {
                correct.GetComponent<AudioSource>().Play(0);
                TenthPage.GetComponent<TenthScript>().run();
            }
        }

        else if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold2 && BookScript.GetComponent<BookScript>().pageNumber == 21)
        {
            correct.GetComponent<AudioSource>().Play(0);
            NinthPage.GetComponent<NinethScript>().run();
        }

        else if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold1 && BookScript.GetComponent<BookScript>().pageNumber == 20)
        {
            correct.GetComponent<AudioSource>().Play(0);
            EighthPage.GetComponent<EighthScript>().run();
        }

        else if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold2 && BookScript.GetComponent<BookScript>().pageNumber == 24)
        {
            correct.GetComponent<AudioSource>().Play(0);
            TwelfthPage.GetComponent<TwelfthScript>().run();
        }

        else if (Input.acceleration.sqrMagnitude >= sqrShakeDetectionThreshold2 && BookScript.GetComponent<BookScript>().pageNumber == 40)
        {
            correct.GetComponent<AudioSource>().Play(0);
            SixteenthPage.GetComponent<SixteenthScript>().run();
        }

    }
   
}
