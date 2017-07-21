using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

	public GameObject player;
	public Animator anim;

	UnityEngine.AI.NavMeshAgent ai;
	// Use this for initialization
	void Start () {
		ai = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> ();

		StartCoroutine (AnimWaitFlex());
	}
	
	public void chaseTarget()
	{
		//Debug.Log (Time.deltaTime);
		anim.SetBool ("IsChasing",true);
		ai.speed = 3f;	
		ai.SetDestination (player.transform.position);

	}

	IEnumerator AnimWaitFlex ()
	{
		yield return new WaitForSeconds (3.2f);

	}

}
