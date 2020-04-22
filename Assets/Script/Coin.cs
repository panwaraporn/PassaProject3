using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    public AudioClip clip;
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
    /*Renderer rend; //ตัวแปลเสียง
    /*int nScore;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        //nScore += 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        rend.enabled = false;

    }*/
}
