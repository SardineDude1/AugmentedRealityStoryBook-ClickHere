using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{
    public GameObject Instrutions;

    public GameObject FirstPage;
    public GameObject SecondPage;
    public GameObject ThirdPage;
    public GameObject FourthPage;
    public GameObject FifthPage;
    public GameObject SixthPage;
    public GameObject SeventhPage;
    public GameObject EighthPage;
    public GameObject ThirteenthPage;
    public GameObject FourteenthPage;
    public GameObject FifteenthPage;
    public GameObject SeventeenthPage;
    public GameObject EighteenthPage;
    public GameObject NineteenthPage;
    public GameObject TwentiethPage;
    public GameObject TwentyfirstPage;
    public GameObject TwentysecondPage;
    public GameObject TwentythirdPage;

    public int pageNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PageNumber()
    {
        /* Get the page the reader is on. */
        GameObject pscript = GameObject.Find("PressScript");
        PressScript pressScript = pscript.GetComponent<PressScript>();
        pageNumber = pressScript.page;

        /* Check if the page number */


        if (pageNumber == 1)
        {
            FirstPage.GetComponent<FirstScript>().run();
        }

        else if (pageNumber == 2)
        {
            SecondPage.GetComponent<SecondScript>().run();
        }

        else if (pageNumber == 3)
        {
            ThirdPage.GetComponent<ThirdScript>().run();
        }

        else if (pageNumber == 4)
        {
            FourthPage.GetComponent<FourthScript>().run();
        }

        else if (pageNumber == 9)
        {
            FifthPage.GetComponent<FifthScript>().run();
        }

        else if (pageNumber == 14)
        {
            SixthPage.GetComponent<SixthScript>().run();
        }

        else if (pageNumber == 19)
        {
            SeventhPage.GetComponent<SeventhScript>().run();
        }

        else if (pageNumber == 30)
        {
            ThirteenthPage.GetComponent<ThirteenthScript>().run();
        }

        else if (pageNumber == 35)
        {
            FourteenthPage.GetComponent<FourteenthScript>().run();
        }

        else if (pageNumber == 40)
        {
            FifteenthPage.GetComponent<FifteenthScript>().run();
        }

        else if (pageNumber > 40 && pageNumber < 45)
        {
            SeventeenthPage.GetComponent<SeventeenthScript>().run();
        }

        else if (pageNumber >= 45 && pageNumber < 50)
        {
            EighteenthPage.GetComponent<EighteenthScript>().run();
        }

        else if (pageNumber >= 50 && pageNumber <= 54)
        {
            NineteenthPage.GetComponent<NineteenthScript>().run();
        }

        else if (pageNumber == 55)
        {
            TwentiethPage.GetComponent<TwentiethScript>().run();
        }
        else if (pageNumber == 56)
        {
            TwentyfirstPage.GetComponent<TwentyfirstScript>().run();
        }
        else if (pageNumber == 57)
        {
            TwentysecondPage.GetComponent<TwentysecondScript>().run();
        }
        else if (pageNumber == 58)
        {
            TwentythirdPage.GetComponent<TwentythirdScript>().run();
        }
    }
}
