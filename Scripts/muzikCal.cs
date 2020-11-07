using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muzikCal : MonoBehaviour
{
    public AudioSource kaynak;
    public AudioClip klip;
    public Slider kaydirici;
    public Text metin;
    public float ses;
    void Start()
    {
        kaynak = this.GetComponent<AudioSource>();
        kaydirici = GameObject.FindGameObjectWithTag("Ses").GetComponent<Slider>();
        metin = GameObject.FindGameObjectWithTag("Sesmetni").GetComponent<Text>();
        kaydirici.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!kaynak.isPlaying)
        {
            kaynak.clip = klip;
            kaynak.Play();
            kaynak.volume = kaydirici.value;
        }
        else
        {
           
            kaynak.volume = kaydirici.value;
            ses = kaynak.volume * 100f;

        }
       
        
        metin.text = "Music Voice:" + ses.ToString();
    }

}
