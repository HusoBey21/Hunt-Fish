using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemiOlustur : MonoBehaviour
{
    public Transform uzun;
    public float gel;
    void Awake()
    {
        uzun = GameObject.FindGameObjectWithTag("Gemi").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        gel += Time.deltaTime;
        if(uzun !=null)
        {
            if(gel >=5f)
            {
                Transform ben = Instantiate(uzun, transform.position, Quaternion.identity) as Transform;
                Destroy(ben.gameObject,8f); //Sekiz saniyede resmi geçecektir.
                gel = 0f;
            }
        }
        
    }
}
