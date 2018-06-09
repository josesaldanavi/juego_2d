using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto : MonoBehaviour {

    public GameObject activ;
    public bool box;

    private void Start()
    {
 
    }
    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.UpArrow) && box==true){
            Destroy(activ);
        }
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
        box = true;
        activ.SetActive(true);
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        box = false;
        if (box)
        {
            Instantiate(activ);
            activ.SetActive(false);
            box = true;
        }
    }*/
}
