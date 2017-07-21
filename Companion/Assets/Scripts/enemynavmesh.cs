using System.Collections;
using System.Linq;
using UnityEngine;

public class enemynavmesh : MonoBehaviour {
	UnityEngine.AI.NavMeshAgent nav;
	public Transform start;
	public Transform end;
	int i=1;


	public bool isChasing=false;
	// Use this for initialization
	void Start () {
		nav = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if (isChasing == false) {
			if (i == 1) {
				nav.SetDestination (start.transform.position);
				if (gameObject.transform.position.x == start.transform.position.x || gameObject.transform.position.z == start.transform.position.z) {
					i = 0;
					Debug.Log ("REACHED POINT 1");

				}
			}
			if (i == 0) {
				nav.SetDestination (end.transform.position);
				if (gameObject.transform.position.x == end.transform.position.x || gameObject.transform.position.z == end.transform.position.z) {
					i = 1;
					Debug.Log ("REACHED POINT 2");

				}
			}

			
		}
	}
		
}
