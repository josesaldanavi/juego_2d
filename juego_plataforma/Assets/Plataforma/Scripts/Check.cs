using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour {
    //checkear la collision contra el suelo
    // Use this for initialization
    private Player_Controller player;
    private Rigidbody2D rb2d;

    void Start()
    {
        player = GetComponentInParent<Player_Controller>();
        rb2d = GetComponentInParent<Rigidbody2D>();
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag=="ground")
        {
            player.grounded = true;

        }
        if (col.gameObject.tag == "platform")
        {
            player.transform.parent = col.transform;
            player.grounded = true;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            rb2d.velocity = new Vector3(0f, 0f, 0f);
            player.transform.parent = null;
            player.grounded = true;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            player.grounded = false;

        }
        if (collision.gameObject.tag == "platform")
        {
            player.transform.parent = null;
            player.grounded =false;

        }
    }
}
