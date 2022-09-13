using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D Corpo;
    private Animator Anim;
    void Start()
    {
        Corpo = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velX = Input.GetAxis("Horizontal");
        Corpo.velocity = new Vector2(velX, 0);

        if(velX == 0)
        {
            Anim.SetBool("Andar", false);
        }
    }
}
