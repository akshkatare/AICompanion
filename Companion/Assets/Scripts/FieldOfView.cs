using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

public class FieldOfView : MonoBehaviour {

	public float viewRadius;
	public float viewAngle;
	public LayerMask playermask;
	public LayerMask worldmask;
	IsBeingAttacked attacking;
	Chase chaser;
	enemynavmesh naver;
	public bool isChasing=false;
	public GameObject[] enemies;


	public void Start()
	{
		chaser = GetComponent<Chase> ();
		naver= GetComponent<enemynavmesh> ();
		attacking = GetComponent<IsBeingAttacked> ();
		enemies = GameObject.FindGameObjectsWithTag ("enemy");
	}

	public void FixedUpdate()
	{
		
		if( attacking.SomeoneIsAttacking==true)
		{
			attacking.BeingAttacked ();
		}
		else
			if (isChasing == false) {
				FindTargets ();
			} 
		
		else {chaser.chaseTarget ();foreach (var en in enemies) {
				en.GetComponent<Chase> ().chaseTarget ();
				en.GetComponent<enemynavmesh> ().isChasing = true;
			}
		}
	}
	public void FindTargets()
	{
		Collider[] Targets = Physics.OverlapSphere (transform.position, viewRadius, playermask);
		for(int i=0;i<Targets.Length;i++)
		{
			Transform targetIdentity = Targets [i].transform;
			Vector3 dirToTarget = (targetIdentity.position - transform.position).normalized;
			if (Vector3.Angle (transform.forward, dirToTarget) < viewAngle / 2) {
				float disToTarget = Vector3.Distance (transform.position, targetIdentity.position);

				if (!Physics.Raycast (transform.position, dirToTarget, disToTarget, worldmask)) {
					// Enter the state here;
					isChasing=true;
					naver.isChasing = true;
					chaser.chaseTarget ();
					Debug.Log ("FOUND YOU  "+isChasing) ;


					foreach (var en in enemies) {
						en.GetComponent<Chase> ().chaseTarget ();
						en.GetComponent<enemynavmesh> ().isChasing = true;
					}

				}
			}
		}

	}



	public Vector3 DirectionFromAngle(float angle,bool angleIsGlobal)
	{
		if (!angleIsGlobal) {
			angle += transform.eulerAngles.y;
		}
		return new Vector3 (Mathf.Sin (angle * Mathf.Deg2Rad), 0, Mathf.Cos (angle * Mathf.Deg2Rad));
	}
		
}
