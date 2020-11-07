using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anaMuzik : MonoBehaviour
{
    public AudioSource kaynak;
    public AudioClip clib;
    // Start is called before the first frame update
    void Start()
    {
        kaynak = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!kaynak.isPlaying)
        {
            kaynak.clip = clib;
            kaynak.Play();
        }
        
    }
}
