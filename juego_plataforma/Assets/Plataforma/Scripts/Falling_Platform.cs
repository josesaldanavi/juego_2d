using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Platform : MonoBehaviour {
    private Rigidbody2D rbd2d;
    private PolygonCollider2D pol;

	// Use this for initialization
	void Start () {
        rbd2d = GetComponent<Rigidbody2D>();
        pol = GetComponent<PolygonCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //hace que sea dinamico automaticamente
            rbd2d.isKinematic = false;
            pol.isTrigger = true;
        }
    }
}
