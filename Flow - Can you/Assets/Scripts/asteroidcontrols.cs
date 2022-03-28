using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidcontrols : MonoBehaviour
{
    private Rigidbody2D rb; 
    private Vector2 direction;
    public GameObject earth;
    private float rotationspeed;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = earth.transform.position - transform.position;
        rb.AddForce(new Vector2(direction.x, direction.y)* speed);

        rotationspeed = Random.Range(-25, 25);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotationspeed) * Time.deltaTime);
        checkposition();
    }

    void checkposition()
    {
        if(transform.position.x > 20|| transform.position.x < -20)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > 20 || transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
}
