using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFly : MonoBehaviour {


	public Transform[] points;
	int i;
	// Use this for initialization
	void Start () {
		i = 0;

	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (i == 8) {
			i = 0;}
		transform.position=Vector3.Lerp (transform.position, points [i].transform.position,Time.deltaTime);
		transform.rotation=Quaternion.Lerp (transform.rotation, points [i].transform.rotation,Time.deltaTime);	
		Collider[] cr = Physics.OverlapSphere (transform.position, 0.01f);
		for(int value=0 ;value<cr.Length;value++) {
			if(cr[value].tag=="World")
				{
				i++;
				}

			}
	}


}
