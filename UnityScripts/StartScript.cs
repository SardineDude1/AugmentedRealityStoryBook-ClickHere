using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static void loadMain()
    {
        SceneManager.LoadScene("Main");
    }
}
