﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {
    public Transform lookTarget;
    public float targetHeight;
    public Vector3 targetPoint;
    private Vector3 localPoint;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void LateUpdate () {
        localPoint = lookTarget.position+ (lookTarget.right * targetPoint.x) + (lookTarget.up * targetPoint.y) + (lookTarget .forward * targetPoint.z);
        transform.position = Vector3.MoveTowards(transform.position, localPoint,5f*Time.deltaTime);
        transform.LookAt(lookTarget);

        /* transform.LookAt(lookTarget);
         float difference =Mathf.Abs(transform.position.y - lookTarget.position.y) ;
         if(difference != targetHeight){
             Vector3 temp = transform.position;
             temp.y = Mathf.MoveTowards(temp.y,lookTarget.position.y + targetHeight, 5f * Time.deltaTime);
             transform.position = temp;
         }
         if(transform.position.y !=lookTarget.position.x){
             Vector3 temp = tranform.position;
         }*/
        
	}
	private void OnDrawGizmos()
	{
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(localPoint, 0.25f);
	}
}
