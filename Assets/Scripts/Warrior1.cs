using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior1 : MonoBehaviour
{
    private Rigidbody2D Corpo;
    private Animator Anim;
    public GameObject MeuAtk;
    public int qtdPulo = 2;
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
        float gravity = Corpo.velocity.y;
        Corpo.velocity = new Vector2(velX, gravity);


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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (qtdPulo > 0)
            {
                qtdPulo--;
                jump();
            }

        }

    }
    public void AtivarATK()
    {
        MeuAtk.SetActive(true);
    }

    public void DesativarATK()
    {
        MeuAtk.SetActive(false);
    }

    void jump()
    {
        Corpo.AddForce(Vector2.up * 330);
    }
    private void OnTriggerStay2D(Collider2D colidiu)
    {
        if (colidiu.gameObject.tag == "Chao")
        {
            qtdPulo = 2;
        }
    }
}
