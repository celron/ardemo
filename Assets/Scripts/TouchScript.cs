using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScript : MonoBehaviour {
	float speed = 2f;
	void OnMouseDrag(){
		float x = transform.rotation.eulerAngles.x;
		float z = transform.rotation.eulerAngles.z;		
		float rotX = Input.GetAxis("Mouse X") * Mathf.Deg2Rad * speed;		
		float rotY = Input.GetAxis("Mouse Y") * Mathf.Deg2Rad * speed;					
		if(x< 80 || (x>=80 && rotX<0)){
			//up
			transform.RotateAround(Vector3.right, -rotX);
		}
		if(x<0 && rotX>0){
			transform.RotateAround(Vector3.up, -rotX);
		}
		if(z < 80 || (z>=80 && rotY<0)){
			//right
			transform.RotateAround(Vector3.up, rotY);
			transform.RotateAround(Vector3.forward,rotY);
		}
		if(z <0 && rotY>0){
			transform.RotateAround(Vector3.right, rotY);	
			transform.RotateAround(Vector3.forward,rotY);					
		}
		Debug.Log("rotX:"+x + " rotZ:"+z +":"+rotY);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
