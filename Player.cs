using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public float speed;
  private Rigidbody2D rb;
  private Vector2 moveAmout;
  private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        moveAmout = moveInput.normalized * speed;
         

        if(moveInput != Vector2.zero){
            anim.SetBool("isRun",true);

        }else{
            anim.SetBool("isRun",false);
        }
        
    }
    

    void FixedUpdate(){
        rb.MovePosition(rb.position + moveAmout * Time.fixedDeltaTime);
        
        
    }
}
