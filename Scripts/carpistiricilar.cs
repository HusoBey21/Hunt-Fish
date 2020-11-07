using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carpistiricilar : MonoBehaviour
{
    //C# 2000 yılında çıkmıştır.
    public Text metin;
    [SerializeField]
    public int balinaSayaci;
    private void Start()
    {
        metin = GameObject.FindGameObjectWithTag("Metin").transform.gameObject.GetComponent<Text>();
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.transform.CompareTag("Gemi"))
        {
            Debug.Log("Karabiber");
            this.GetComponent<canlar>().canYitir(2f);

        }
        

    }
    private void Update()
    {
        balinaSayaci = this.GetComponent<tutma>().eklenenler;
        metin.text = "Hunted Whales:" + balinaSayaci.ToString(); //Bunu dizgeye çevirir.
    }
}
