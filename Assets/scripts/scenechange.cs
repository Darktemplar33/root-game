using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
   
    public void start()
    {
        SceneManager.LoadScene(1);

    }

    public void quit()
    {
        Application.Quit();
    }

    public void retry()
    {
        SceneManager.LoadScene(1);

    }

    public void title()
    {
        SceneManager.LoadScene(0);

    }

}
