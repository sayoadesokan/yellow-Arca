using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyballs : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Respawn" || collision.gameObject.tag == "Respawn1" || collision.gameObject.tag == "Sizer" || collision.gameObject.tag == "Addpoint" || collision.gameObject.tag == "Freeze" || collision.gameObject.tag == "Slowmo")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Destroy(gameObject);
        }
    }
}
