﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextIntroducction : MonoBehaviour {

	void Update () {
        if(Input.GetKeyDown(KeyCode.LeftArrow) ||Input.GetKeyDown(KeyCode.RightArrow) ){
            Destroy(gameObject);
        }
	}
}
