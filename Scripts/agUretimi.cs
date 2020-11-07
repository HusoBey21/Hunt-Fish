using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agUretimi : MonoBehaviour
{
    public Transform aglar,kartal,yonelmeNesnesi;
    public bool saga;
    public void Start()
    {
        aglar = GameObject.FindGameObjectWithTag("Küre").transform;
        kartal = GameObject.FindGameObjectWithTag("Seçkinkartal").transform;
        yonelmeNesnesi = GameObject.FindGameObjectWithTag("Yardımcı").transform;

    }
    public void Update()
    {
       
    }

    public void agUret()
    {
        if(aglar !=null)
        {
            Debug.Log("Benim de bu cihandan gidişim");
            Transform vurdu = Instantiate(aglar, new Vector3(transform.position.x,kartal.position.y,transform.position.z), Quaternion.identity) as Transform;

            vurdu.transform.LookAt(kartal);
            vurdu.rotation = Quaternion.LookRotation(kartal.eulerAngles); //Kartalın dönüş açısını temel alacak.
            Vector3 uzaklik = (kartal.position - vurdu.position);
            vurdu.position += uzaklik * 5f * Time.deltaTime; 

            RaycastHit2D a = Physics2D.Raycast(transform.position,Vector3.left,15f*Time.deltaTime); //Görüş açısı olarak değerlendirilir.
            
            if(a.transform !=null)
            {
                if(a.transform.tag==yonelmeNesnesi.tag)
                {
                    saga = true;
                }
                else
                {
                    saga = false;
                }
            }
            if (saga)
            {
                vurdu.position += Vector3.forward * 5f;

            }
            else
            {
                vurdu.position += Vector3.down * 5f;
            }
            Destroy(vurdu.gameObject, 20f);
           

        }

    }
}
