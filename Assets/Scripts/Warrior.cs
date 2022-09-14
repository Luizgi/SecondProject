using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    private Rigidbody2D Corpo;
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Corpo = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimento
        float velX = Input.GetAxis("Horizontal");
        Corpo.velocity = new Vector2(velX, 0);

        if (velX == 0)
        {
            Anim.SetBool("Andar", false);
        }
        else
        {
            Anim.SetBool("Andar", true);
            if (velX < 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Anim.SetTrigger("Attack");
        }

    }
}
