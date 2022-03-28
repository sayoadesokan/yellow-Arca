using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoretext;
    public int score;
    public Text losescore;
    public GameObject player;
    public GameObject closeanim;
    public GameObject levellostui;
    public GameObject openanim;
    public GameObject introanim;
    public Text highscore;
    public GameObject pauseui;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject controlspawn;
    Powerupscript pscript;

    public void Start()
    {
        pscript = GetComponent<Powerupscript>();


        //time courotines
        StartCoroutine(addlevelsec());
        StartCoroutine(addlevelsec2());
        StartCoroutine(addlevelsec3());
        StartCoroutine(addlevelsec4());
        StartCoroutine(addlevelsec5());
        StartCoroutine(controlspawner());

        //anim and highscore
        introanim.SetActive(true);
        openanim.SetActive(true);
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();

        //Spawners
        //StartCoroutine(controlspawner());
        FindObjectOfType<AudioManager>().Play("Theme");
    }
    public void levellost()
    {
        closeanim.SetActive(true);
        StartCoroutine(closelost());
        pauseui.SetActive(false);
        //pscript.pupscore = 0;
        FindObjectOfType<AudioManager>().Play("Fail");
    }
 
    public void levelgain()
    {
        scoretext.text = score.ToString();

    }

    void FixedUpdate()
    {
        scoretext.text = score.ToString();
        losescore.text = score.ToString();

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highscore.text = score.ToString();
        }
    }

    IEnumerator closelost()
    {
        yield return new WaitForSeconds(3f);

        levellostui.SetActive(true);
    }

    IEnumerator controlspawner()
    {
        yield return new WaitForSeconds(4.5f); //Remianing go with +45 and the like

        introanim.SetActive(false);
        openanim.SetActive(false);
        controlspawn.SetActive(true);
        spawner1.SetActive(true);
        spawner3.SetActive(true);
    }

    IEnumerator addlevelsec()
    {
        yield return new WaitForSeconds(45f);

        Debug.Log("45sec up!"); 
        spawner1.SetActive(true);
        spawner2.SetActive(true);
        spawner4.SetActive(false);
        spawner3.SetActive(true);

    }

    IEnumerator addlevelsec2()
    {
        yield return new WaitForSeconds(90f);

        Debug.Log("90sec up!");
        spawner1.SetActive(true);
        spawner3.SetActive(true);
        spawner4.SetActive(true);
        spawner2.SetActive(false);

    }

    IEnumerator addlevelsec3()
    {
        yield return new WaitForSeconds(135f);

        Debug.Log("135sec up!");
        spawner1.SetActive(false);
        spawner3.SetActive(true);
        spawner4.SetActive(true);
        spawner2.SetActive(true);

    }

    IEnumerator addlevelsec4()
    {
        yield return new WaitForSeconds(180f);

        Debug.Log("180sec up!");
        spawner1.SetActive(true);
        spawner3.SetActive(false);
        spawner4.SetActive(true);
        spawner2.SetActive(true);

    }

    IEnumerator addlevelsec5()
    {
        yield return new WaitForSeconds(225f);

        Debug.Log("225sec up!");
        spawner1.SetActive(true);
        spawner3.SetActive(true);
        spawner4.SetActive(true);
        spawner2.SetActive(true);

    }
}
