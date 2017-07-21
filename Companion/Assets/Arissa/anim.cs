using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour {

	Animator animat;

	// Use this for initialization
	void Start () {
		animat = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.A)) {
			animat.SetBool ("WPressed", true);
		}else {
			if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) {
				animat.SetBool ("WPressed", false);
			}
		} 


		if (Input.GetKeyDown (KeyCode.LeftShift) && Input.GetKeyDown (KeyCode.W)) {
			animat.SetBool ("Walking", true);
		}
		if (Input.GetKeyUp (KeyCode.LeftShift) || Input.GetKeyUp (KeyCode.W)) {
			animat.SetBool ("Walking", false);
		}
			




			}
}
