using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movinggrid : MonoBehaviour
{
    public float speed;
    public float endx;
    public float startx;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(transform.position.x <= endx)
        {
            Vector2 pos = new Vector2(startx, transform.position.y);
            transform.position = pos; 
        }
        //StartCoroutine(speedincrease1());
        //StartCoroutine(speedincrease2());
    }
    IEnumerator speedincrease1()
    {
        yield return new WaitForSeconds(120f);

        speed = 4;
        Time.timeScale = 1.1f;
    }

    IEnumerator speedincrease2()
    {
        yield return new WaitForSeconds(210f);

        speed = 5;
        Time.timeScale = 1.2f;
    }
}
