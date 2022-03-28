using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscript : MonoBehaviour
{
    public void restart()
    {
        //FindObjectOfType<InterAd>().ShowAd();
        SceneManager.LoadScene(1);
    }
}
