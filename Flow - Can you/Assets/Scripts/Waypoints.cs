using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject [] waypoints;
    int current = 0;
    float rotspeed;
    public float speed;
    float wradius= 1;
    int control;


    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < wradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

        /*if (Input.GetMouseButtonDown(0))
        {
            if (control >= 100)
            {
                waypoints[1].SetActive(true);
                waypoints[0].SetActive(false);
                Debug.Log("Mouseclicks1");
            }
            else if (control <= 50)
            {
                waypoints[1].SetActive(false);
                waypoints[0].SetActive(true);
                Debug.Log("Mouseclicks2");
            }
        }*/
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Triggerball1")
        {
            waypoints[1].SetActive(true);
            waypoints[0].SetActive(false);
            Debug.Log("Mouseclicks1");
            control = 50;
        }
        else if (collision.gameObject.tag == "Triggerball2")
        {
            waypoints[1].SetActive(false);
            waypoints[0].SetActive(true);
            Debug.Log("Mouseclicks2");
            control = 100;
        }
       
    }*/

}
