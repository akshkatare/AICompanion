using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sneak : MonoBehaviour {

	public float ViewRadius;
	bool looking;
	UnityEngine.AI.NavMeshAgent ai;
	public Transform start;
	public Transform end;
	public GameObject body;
	Material m;
	public Material[] material;
	public Material Glow;
	public Material Hide;

	Renderer rend;

	// Use this for initialization
	void Start () {
		ai = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		transform.position = start.transform.position;
		//Material m=gameObject.GetComponent<Material> ();

		rend = body.GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = Glow;
	}

	//Draw Gizmos in the scene
	void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere (transform.position, ViewRadius);
	} 	



	// Update is called once per frame
	public void ChaseEnemy () {
		body.GetComponent<Renderer> ().sharedMaterial = Glow;
		ai.SetDestination (end.position);
		
		Collider[] cr = Physics.OverlapSphere (transform.position,ViewRadius);
		foreach (Collider item in cr) {

			if(item.CompareTag("enemy") )
				{
			looking=CheckLook (item);


				if (looking == true) {
					Debug.Log ("LOOKING AT WOLF");

					//ai.SetDestination (start.position);
					ai.SetDestination(transform.position);
					rend.sharedMaterial = Hide;

				}

				else {//ai.speed = 1.38f;//make wolf appear again

					//body.GetComponent<MaterialSwapper> ().Show ();


					ai.SetDestination (end.position);
				}
			}
			looking = false;	
		}
		
	}

	//check if the enemy is looking towards you or away from you.
	bool CheckLook(Collider enemy)
	{
		Vector3 dirFromAtoB = (enemy.transform.position -transform.position ).normalized;
		float dotProd = Vector3.Dot (dirFromAtoB, enemy.transform.forward);
		if (dotProd > 0.7) {
			return false;
		} else {return true;
		}

	}


/*	void CheckAngleDir(Vector3 fwd,Vector3 targetDir,Vector3 up)
	{
		Vector3 perp = Vector3.Cross (fwd, targetDir);
		float dir = Vector3.Dot (perp, up);
		if(dir>0.0f)
			
	}*/


}
