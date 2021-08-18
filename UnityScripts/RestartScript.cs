using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour
{

    public void CustomButton_onClick()
    {
        SceneManager.LoadScene("Main");
    }
}
