using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class kartalHareketi : MonoBehaviour
{
    public Transform yeni;
    [SerializeField]
    
    private void Start()
    {
        yeni = GameObject.FindGameObjectWithTag("Resim").transform;
        
        
        
    }


    void FixedUpdate()
    {
        float vurun = yeni.gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
        Debug.Log(vurun + ":Ederlezi");
        float yatay = Input.GetAxis("Vertical")*5f;
        yatay = Mathf.Clamp(yatay,-vurun,vurun); //Bunda kısıtladım.Ne kadar doğru öğreniriz.
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        transform.Translate(0f, yatay, 0f); //Bu yatay eksende hareket sağlar
        if(Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0);

        }


        
    }

}
