using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballsound : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn" || collision.gameObject.tag == "Respawn1" || collision.gameObject.tag == "Sizer" || collision.gameObject.tag == "Addpoint" || collision.gameObject.tag == "Freeze" || collision.gameObject.tag == "Slowmo")
        {
           // Debug.Log("Sound it!");
            FindObjectOfType<AudioManager>().Play("BallBounce");
        }
    }
}
