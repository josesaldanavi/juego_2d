using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {
    public float velocidad=2f;
    private Rigidbody2D rbd2;
    public bool grounded;
    private Animator anim;
    public float maxForce=5;
    public float jumpForce = 6.5f;
    private bool jump;
    public float x = 1;
    public float y = 1;
    public float z = 1;
    public float lifes = 1f;
    public GameObject player;

	// Use this for initialization
	void Start () {
        rbd2=GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", Mathf.Abs(rbd2.velocity.x));
        anim.SetBool("Grounded", grounded);
        //GetKeyDown lo le solo una vez y no en cada fotograma
        if(Input.GetKeyDown(KeyCode.UpArrow)&& grounded){
            jump = true;
        }
	}

    private void FixedUpdate()
    {

        Vector3 fixedVelocity = rbd2.velocity;
        fixedVelocity.x *= 0.75f;


        if(grounded){
            rbd2.velocity = fixedVelocity;
        }

        float h = Input.GetAxis("Horizontal");
        rbd2.AddForce(Vector2.right * h * velocidad);

        float limitForce = Mathf.Clamp(rbd2.velocity.x,-maxForce,maxForce);
            rbd2.velocity = new Vector2(limitForce, rbd2.velocity.y);
        if( h > 0.1f){
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(h < -0.1f){
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if(jump){
            //definir que es un movimiento de fuerza
            rbd2.velocity = new Vector2(rbd2.velocity.x, 0);
            rbd2.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
        }
        
    }
    //detecta cuando se desaparece de la escena
	private void OnBecameInvisible()
    {
        transform.position = new Vector3(x,y,z);
        if (lifes > 0)
        {
            lifes --;
        }
        else
        {
            Destroy(player);
        }
	}
}
