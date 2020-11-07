using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
//18 Ekim 2020 Pazar
public class baligaGecitYok : MonoBehaviour
{
    public Transform hedefteki,gidecek;
    void Start()
    {
        if (hedefteki != null)
        {
            hedefteki = GameObject.FindGameObjectWithTag("Kamburbalina").transform; //hedefteki nesneyi belirler.
        }
        gidecek = GameObject.FindGameObjectWithTag("Küp").transform;

    }
    private void FixedUpdate()
    {
        if (hedefteki != null)
        {
            float uzaklik = Vector3.Distance(this.transform.position, hedefteki.position);
            float k = (this.transform.position.x - hedefteki.position.x);
            Debug.Log(uzaklik + ":Dünya dünya yalan dünya");
            Debug.Log(k + "Tekne ve balina arası mesafe");
            int vur = LayerMask.GetMask(hedefteki.name);
            if (this.transform.GetComponent<BoxCollider2D>().IsTouchingLayers(vur))
            {
                Debug.Log("Ah ulan ayrılık");
                if (hedefteki != null)
                {
                    hedefteki.position = gidecek.position;
                }
            }

        }
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hedefteki != null)
        {
            if (collision.gameObject.tag == hedefteki.tag)
            {
                Debug.Log("22 yaş bunalımı");
                float uzaklik = Vector3.Distance(this.transform.position, collision.gameObject.transform.position);

                Debug.Log(uzaklik + ":Dünya dünya yalan dünya");
                if (transform.position.y == collision.gameObject.transform.position.y && uzaklik <= 7f)
                {
                    hedefteki.position = gidecek.position; //Aynı işlevi görüyor aslında.
                }
            }
        }
    }


}
