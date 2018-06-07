using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour {
    //checkear la collision contra el suelo
    // Use this for initialization
    private Player_Controller player;

    void Start()
    {
        player = GetComponentInParent<Player_Controller>();
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        player.grounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        player.grounded = false;
    }
}
