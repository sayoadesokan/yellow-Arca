using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveup : MonoBehaviour
{
    public GameObject targetup;
    public GameObject targetdown; //do not forget to extend this for other animations and all
    private Vector2 direction;
    private Rigidbody2D rb;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rb = GetComponent<Rigidbody2D>();
            direction = targetup.transform.position - transform.position;
            rb.AddForce(new Vector2(direction.x, direction.y) * speed * Time.fixedDeltaTime);
            Debug.Log("Moveup");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Up")
        {
            this.gameObject.GetComponent<movedown>().enabled = true;
            this.gameObject.GetComponent<moveup>().enabled = false;
            FindObjectOfType<AudioManager>().Play("PlayerMove");
        }
    }
}
