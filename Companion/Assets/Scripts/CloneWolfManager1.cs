using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneWolfManager1 : MonoBehaviour {


	AttackMutant attack;



	// Use this for initialization
	void Start () {
		attack = GetComponent<AttackMutant> ();
		attack.Khatamkrde ();
	}


}
