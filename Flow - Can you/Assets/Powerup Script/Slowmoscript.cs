using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class Slowmoscript : MonoBehaviour
{
    public float slowMotionTimeScale = 0.5f;
    public bool slowMotionEnabled = false;
    Powerupscript pscript;
    public GameObject slowmo;

    public Color colorbrown;
    public Color coloryellow;
    SpriteRenderer spriterenderer;

    [System.Serializable]
    public class AudioSourceData
    {
        public AudioSource audioSource;
        public float defaultPitch;
    }

    AudioSourceData[] audioSources;

    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        pscript = GetComponent<Powerupscript>();
        //Find all AudioSources in the Scene and save their default pitch values
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        audioSources = new AudioSourceData[audios.Length];

        for (int i = 0; i < audios.Length; i++)
        {
            AudioSourceData tmpData = new AudioSourceData();
            tmpData.audioSource = audios[i];
            tmpData.defaultPitch = audios[i].pitch;
            audioSources[i] = tmpData;
        }

        SlowMotionEffect(slowMotionEnabled);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Slowmo")
        {
            pscript.pupscore = 3;
            spriterenderer.color = colorbrown;
            slowmo.SetActive(true);
            slowMotionEnabled = !slowMotionEnabled;
            SlowMotionEffect(slowMotionEnabled);

            StartCoroutine(offslowmo());
            StartCoroutine(animationss());
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame // I USED COLLISION, INCASE YOU WANT TO USE A BUTTON TOO
    /*void Update() 
    {
        //Activate/Deactivate slow motion on key press
        if (Input.GetKeyDown(KeyCode.Q))
        {
            slowMotionEnabled = !slowMotionEnabled;
            SlowMotionEffect(slowMotionEnabled);
        }
    }*/

    IEnumerator offslowmo()
    {
        yield return new WaitForSeconds(3f);

        slowMotionEnabled = !slowMotionEnabled;
        SlowMotionEffect(slowMotionEnabled);
        spriterenderer.color = coloryellow;
        pscript.pupscore = 0;
        Time.timeScale = 1;
    }

    IEnumerator animationss()
    {
        yield return new WaitForSeconds(0.3f);

        slowmo.SetActive(false);
    }

    void SlowMotionEffect(bool enabled)
    {
        Time.timeScale = enabled ? slowMotionTimeScale : 1;
        for (int i = 0; i < audioSources.Length; i++)
        {
            if (audioSources[i].audioSource)
            {
                audioSources[i].audioSource.pitch = audioSources[i].defaultPitch * Time.timeScale;
            }
        }
    }
}
