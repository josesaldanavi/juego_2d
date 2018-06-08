using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto : MonoBehaviour {

    public GameObject activ;

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Destroy(activ);
        }
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
        activ.SetActive(true);
	}
}
