using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {
    public float velocidad=2f;
    private Rigidbody2D rbd2;
    public bool grounded;
    private Animator anim;
    private float maxForce=5;

	// Use this for initialization
	void Start () {
        rbd2=GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", Mathf.Abs(rbd2.velocity.x));
        anim.SetBool("Grounded", grounded);
	}

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rbd2.AddForce(Vector2.right * h * velocidad);

        float limitForce = Mathf.Clamp(rbd2.velocity.x,-maxForce,maxForce);
            rbd2.velocity = new Vector2(limitForce, rbd2.velocity.y);
        
    }
}
