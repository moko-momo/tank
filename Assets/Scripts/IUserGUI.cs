using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUserGUI : MonoBehaviour {
	IUserAction action;
	float speed = 0.1f;
	//float x;
	float y;

	// Use this for initialization
	void Start () {
		action = GameDirector.getInstance().currentSceneController as IUserAction;	
	}

	// Update is called once per frame
	void Update () {

		if (!action.isGameOver()) {
			if (Input.GetKey(KeyCode.UpArrow)) {
				action.moveForward();
			}

			if (Input.GetKey(KeyCode.DownArrow)) {
				action.moveBackWard();
			}

			if (Input.GetKeyDown(KeyCode.Space)) {
				action.shoot();	
			}
			　　if(Input.GetMouseButton(0)){
				　　　　y = Input.GetAxis("Mouse X") * Time.deltaTime * speed + Input.GetAxis("Mouse Y") * Time.deltaTime * speed;               
				　　　//　x = Input.GetAxis("Mouse Y") * Time.deltaTime * speed; 
			　　}else{
				　　　　 y = 0 ;
			}
			this.transform.Rotate(new Vector3(0,y,0));
		}
	}
}
