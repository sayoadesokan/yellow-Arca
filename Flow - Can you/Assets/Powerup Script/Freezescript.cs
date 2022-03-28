using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezescript : MonoBehaviour
{
    Rigidbody2D rb;
    Powerupscript powerscript;
    spawnscript spawnscript;
    void Start()
    {
        rb = FindObjectOfType<Rigidbody2D>();
        powerscript = FindObjectOfType<Powerupscript>();
        spawnscript = FindObjectOfType<spawnscript>();
    }

    void FixedUpdate()
    {
        if (powerscript.pupscore == 2)
        {
            Debug.Log("Gameobject on the screen destroyed!");
            Destroy(this.gameObject);
            Destroy(gameObject);
            powerscript.pupscore = 0;
        }
    }

    IEnumerator stopfreeze()
    {
        yield return new WaitForSeconds(4f);
        Debug.Log("Unfreeze");
        powerscript.pupscore = 0;
        rb.constraints = RigidbodyConstraints2D.None;
        spawnscript.spawnrate = 3f;
    }

    IEnumerator stopddestroy()
    {
        yield return new WaitForSeconds(0.5f);

        powerscript.pupscore = 0;
    }
}
