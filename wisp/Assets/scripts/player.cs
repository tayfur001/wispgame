using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private const string Message = "temas edildi";
    public float speed;
    public float power;
    public float power_ill;
    public bool ucma;

    private Animator animator;
    private Rigidbody2D rb2d;
    

    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        ucma = false;

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);

        for (int i = 0; i<Input.touchCount;++i)
        { if(Input.GetTouch(i).phase == TouchPhase.Began)
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, power));
                animator.SetTrigger("jump");
                ucma = true;
            }
                
                    }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, power));
            animator.SetTrigger("jump");
            ucma = true;
            
        }

        if (ucma)
        {
            if (rb2d.velocity.y < 0)
            {
                animator.SetTrigger("fall");
              


            }

        }
        else { ucma = false; }
        
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "toz")
        {
            temas.gameObject.transform.GetComponent<moondust>().temasDust = true;
        }


    }
}

