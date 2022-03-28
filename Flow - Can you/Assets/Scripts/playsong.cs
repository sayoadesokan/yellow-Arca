using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsong : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Theme");
    }
}
