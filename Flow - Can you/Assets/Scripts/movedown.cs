using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedown : MonoBehaviour
{
    public GameObject targetdown;
    private Vector2 direction;
    private Rigidbody2D rb;
    public float speed;

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rb = GetComponent<Rigidbody2D>();
            direction = targetdown.transform.position - transform.position;
            rb.AddForce(new Vector2(direction.x, direction.y) * speed * Time.fixedDeltaTime);
            Debug.Log("Moveup");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Down")
        {
            this.gameObject.GetComponent<movedown>().enabled = false;
            this.gameObject.GetComponent<moveup>().enabled = true;
            FindObjectOfType<AudioManager>().Play("PlayerMove");
        }
    }
}
