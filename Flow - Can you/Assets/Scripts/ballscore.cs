using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscore : MonoBehaviour
{
    public GameManager gamemanager;
    public GameObject plusfiveanim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn1")
        {
            gamemanager.score += 1;
            gamemanager.levelgain();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Addpoint")
        {
            gamemanager.score += 5;
            plusfiveanim.SetActive(true);
            gamemanager.levelgain();
            Destroy(collision.gameObject);
            StartCoroutine(stopanim());
        }
    }

    IEnumerator stopanim()
    {
        yield return new WaitForSeconds(0.3f);

        plusfiveanim.SetActive(false);
    }
}
