using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avMevsimi : MonoBehaviour
{
    public Transform ag,ureten,gorus,balik;
    public float zamanSayaci;
    

    // Update is called once per frame
    void Start()
    {
        ag = GameObject.FindGameObjectWithTag("Küre").transform; //Gerekenleri buldu
        ureten = GameObject.FindGameObjectWithTag("Seçkinkartal").transform;
        
        gorus = GameObject.FindGameObjectWithTag("Üretici").transform;
       balik = GameObject.FindGameObjectWithTag("Kamburbalina").transform;
        
        
      
    }
    private void Update()
    {
        
        bakisAcisi();
       
    }
    public void bakisAcisi()
    {
         //Bir görüş alanı belirlendi.
        {
            zamanSayaci += Time.deltaTime;
            
                if (ag != null)
                {
                if (zamanSayaci >= 5f)
                { 
                    
                    Debug.Log("13 Ekim 2020 Salı");
                    

                    Transform aglar = Instantiate(ag, transform.position, Quaternion.identity) as Transform;

                    
                   
                    
                    float basla = DateTime.Now.Second;
                    Debug.Log(basla);
                    
                    RaycastHit2D sd = Physics2D.Raycast(transform.position,gorus.position);
                    if (sd.transform != null)
                    {
                        if (balik != null)
                        {

                            if (sd.transform.tag == balik.tag)
                            {


                                sd.transform.SetParent(this.transform, false);

                            }
                        }
                        
                    }
                    


                    Debug.Log("2000:" + aglar.position);
                   
                  
                     



                    Destroy(aglar.gameObject, 20f);
                    float bitir = DateTime.Now.Second;
                    float k = bitir - basla; //Amaç üretme ile yok etme arasındaki süreyi saptamaya çalışmak.
                    Debug.Log("Süre:" + k);
                    Debug.Log(bitir);
                    zamanSayaci = 0f;
                }
                }
                

            }
        }
    
}
