using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public Transform[] Points;
	public Camera main;
	int current=0;
	// Use this for initialization
	void Start () {
		main.transform.position = Points [0].position;
	}
	
	// Update is called once per frame
	public void next()
	{
		current++;
		if (current == Points.Length) {
		
			current = 0;
		}
		main.transform.position = Points [current].position;


	}

	public void previous()
	{
		current--;
		if (current == -1) {
		
			current = Points.Length - 1;
		}
		main.transform.position = Points [current].position;

	}
}
