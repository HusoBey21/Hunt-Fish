using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyon : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isPlaying", true);
        
    }
}
