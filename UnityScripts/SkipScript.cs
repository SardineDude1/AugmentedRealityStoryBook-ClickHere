using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipScript : MonoBehaviour
{
    public void skip()
    {
        GameObject pscript = GameObject.Find("PressScript");
        PressScript PressScript = pscript.GetComponent<PressScript>();

        if (PressScript.page < 4)
        {
            PressScript.page += 1;
        }
        
        else if (PressScript.page == 4)
        {
            PressScript.page += 5;
        }

        else if (PressScript.page == 9)
        {
            PressScript.page += 5;
        }

        else if (PressScript.page == 14)
        {
            PressScript.page += 5;
        }

        else if (PressScript.page == 19)
        {
            PressScript.page += 1;
        }

        else if (PressScript.page == 20)
        {
            PressScript.page += 1;
        }


        GameObject mainscript = GameObject.Find("BookScript");
        BookScript bookScript = mainscript.GetComponent<BookScript>();
        bookScript.PageNumber();
    }
}
