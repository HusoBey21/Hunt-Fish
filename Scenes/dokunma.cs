using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokunma : MonoBehaviour
{
    public List<Transform> donusum;
    solaYonel renk;
    Transform fish;
    public void Start()
    {
        donusum = new List<Transform>(); //Bunu ilklendirdik.
        renk = GetComponent<solaYonel>();
        if (fish != null)
        {
            fish = GetComponent<temas>().balik;
        }
    }
     void FixedUpdate()
    {
        renk.Uretim();
    }


    void OnCollisionEnter2D(Collision2D collider)
    {
       
        if(collider.gameObject.transform.tag==fish.tag)
        {
            
            Debug.Log("Vurun");
            donusum.Add(fish);
        }
        
        
    }
}
