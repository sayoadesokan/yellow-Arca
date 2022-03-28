using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{
    public GameObject[] balls;
    public GameObject[] spawnpoints;
    public float spawnrate;
    private float nextspawn;
    Rigidbody2D rb;
    Powerupscript powerscript;
    // Start is called before the first frame update
    void Start()
    {
        rb = FindObjectOfType<Rigidbody2D>();
        powerscript = FindObjectOfType<Powerupscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nextspawn > 0)
        {
            nextspawn -= Time.deltaTime;
        }
        if (nextspawn <= 0)
        {
            spawnposition();
        }

    }

    void spawnposition()
    {
        nextspawn = spawnrate;
        Vector2 position = spawnpoints[Random.Range(0, spawnpoints.Length)].transform.position;
        GameObject asteroidclone = Instantiate(balls[Random.Range(0, balls.Length)], new Vector2(position.x, position.y), transform.rotation);
    }
}
