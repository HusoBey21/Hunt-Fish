using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//17 Ekim 2020 Cumartesi
public class canlar : MonoBehaviour
{
    public float saglik = 100f;
    public Text metin,yeniMetin;
    public float zaman;
    public Animator anim;
    private void Start()
    {
        metin = GameObject.FindGameObjectWithTag("Metinsel").GetComponent<Text>(); //Metin eklendi.
        yeniMetin = GameObject.FindGameObjectWithTag("Hasmetin").GetComponent<Text>();
        metin.text = "Health:" + saglik.ToString(); //Can bilgisi taşır.
        anim = this.GetComponent<Animator>();
    }
    private void Update()
    {
        zaman += Time.deltaTime; //İleriye doğru gidiş sağlanır.
        metin.text = "Health:" + saglik.ToString();
        if(zaman >=10f)
        {
            canYitir(6f);
            zaman = 0f;
        }
        

    }

    public void canYitir(float hasar)
    {
        saglik -= hasar;
        if(saglik >=0f && saglik <=15f)
        {
            StartCoroutine(Alarm());
        }
        if(saglik <=0f)
        {
            saglik = 0f;
            anim.SetBool("isDead", true); //Ölümü sağlar.
            Destroy(gameObject); //Oyun nesnesini yok eder.
            SceneManager.LoadScene(1); //Bu koşul sağlandığında oyun yeniden başlayacak.
        }
        metin.text = "Health:" + saglik.ToString(); //Can bilgisi taşır.
    }
    public void canEkle(float ekle)
    {
        saglik += ekle;
        if(saglik>=100f)
        {
            saglik = 100f;
        }
    }
    IEnumerator Alarm()
    {
        Debug.Log("1998");
        yield return new WaitForSeconds(.5f);
        yeniMetin.text = "Your health is reducing";
        yield return new WaitForSeconds(.5f);
        yeniMetin.gameObject.SetActive(false);
        yield return new WaitForSeconds(.5f);
        yeniMetin.gameObject.SetActive(true);

    }

}
