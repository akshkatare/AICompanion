using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBeingAttacked : MonoBehaviour {


	public bool SomeoneIsAttacking=false;
	Animator anim;
	FieldOfView fw;
	UnityEngine.AI.NavMeshAgent ai;
	// Use this for initialization
	void Start () {
		fw = GetComponent<FieldOfView> ();
		ai = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void BeingAttacked() {
		fw.isChasing = false;
		if (SomeoneIsAttacking==true) {

			fw.isChasing = false;
			Debug.Log (gameObject.name + " Being attacked");

			ai.SetDestination (transform.position);
			//anim.SetBool ("IsChasing", false);
			anim.SetBool ("BeingAttacked", true);

		}
		
	}
}
