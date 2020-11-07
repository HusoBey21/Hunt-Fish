using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temas : MonoBehaviour
{
    public Transform balik;
    public void Start()
    {
        if (balik != null)
        {
            balik = this.GetComponent<baligaGecitYok>().hedefteki;
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.transform.tag=="Küre")
        {
            
            
                collision.gameObject.transform.SetParent(balik, false);
                Debug.Log("Ebeveyn oldu");
            
        }
    }
}
