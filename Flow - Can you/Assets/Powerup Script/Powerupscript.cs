using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerupscript : MonoBehaviour
{
    public GameManager gamemanager;
    public float pupscore;
    Rigidbody2D rb;
    Transform thisplayer;
    private shake shake;
    public GameObject bombanim;

    void Start()
    {
        rb = FindObjectOfType<Rigidbody2D>();
        pupscore = 0;
        thisplayer = GetComponent<Transform>();
        shake = GameObject.FindGameObjectWithTag("Screenshake").GetComponent<shake>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Sizer")
        {
            shake.camshake();
            Debug.Log("Should destroy all gameobjects on the screen");
            pupscore = 2;
            pupscore = 2;
            pupscore = 2;
            bombanim.SetActive(true);
            Destroy(collision.gameObject);
            StartCoroutine(animationbb());
            
        }

        IEnumerator animationbb()
        {
            yield return new WaitForSeconds(0.3f);

            bombanim.SetActive(false);
        }
    }
}
