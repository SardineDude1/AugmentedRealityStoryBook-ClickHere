using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    public static void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
