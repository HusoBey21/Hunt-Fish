using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sagaGit : MonoBehaviour
{
   

    //12 Ekim 2020 Pazartesi
    void Update()
    {
        float asd = Mathf.Clamp(transform.position.x, -10f, 10f);
        transform.position = new Vector3(asd, transform.position.y, transform.position.z);

        transform.position += Vector3.right * 3f * Time.deltaTime; //Sağa doğru gidişi sağlar.
        

    }
}
