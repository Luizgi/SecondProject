using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esqueleto : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D body;
    private Animator anim;
    public float velX = 1;
    public float posInit;
    public float posEnd;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }
    void Mover()
    {
        body.velocity = new Vector2(velX, 0);
        if(velX !=0)
        {
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }
        if(transform.position.x < posInit)
        {
            velX = 3;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if(transform.position.x > posEnd)
        {
            velX = -3;
            transform.localScale = new Vector3(1, 1, 1);     
        
    }

    }

}