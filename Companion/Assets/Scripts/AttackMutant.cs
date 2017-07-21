using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMutant : MonoBehaviour {

	public GameObject[] enemies;
	FieldOfView fw;
	Collider cr;
	UnityEngine.AI.NavMeshAgent naver;
	public GameObject target;
	public bool attack=false;
	// Use this for initialization
	void Start () {
		naver = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		enemies = GameObject.FindGameObjectsWithTag ("enemy");
		foreach (GameObject item in enemies) {

			fw = item.GetComponent<FieldOfView> ();
			if (fw.isChasing == true) {
				attack = true;
				Khatamkrde ();
			}
			
			
		}


	}

	public void Khatamkrde()
	{



	/*	enemies = GameObject.FindGameObjectsWithTag ("enemy");

		foreach (GameObject item in enemies) {
			if (item.GetComponent<IsBeingAttacked> ().SomeoneIsAttacking == false) {
				item.GetComponent<IsBeingAttacked> ().SomeoneIsAttacking = true;
				naver.SetDestination (item.transform.position);
			}
		}*/

		naver.SetDestination (target.transform.position);
		naver.speed = 4f;

	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("enemy")){
		//	other.transform.LookAt (gameObject.transform);
			GetComponent<UnityEngine.AI.NavMeshAgent> ().SetDestination (other.transform.position);
			//GetComponent<UnityEngine.AI.NavMeshAgent> ().Stop();
			GetComponent<Animator>().SetBool("Run",true);
			transform.LookAt (other.transform);
			other.GetComponent<IsBeingAttacked>().SomeoneIsAttacking=true;
		}
	}


}
