using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balllost : MonoBehaviour
{
    public GameManager GameManager;
    public GameObject explosion;
    public GameObject disapper; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Instantiate(explosion, this.transform.position, Quaternion.identity);
            this.transform.position = disapper.transform.position; 
            GameManager.levellost();
            Destroy(collision.gameObject);
        }
    }
}
