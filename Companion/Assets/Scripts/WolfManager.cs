using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfManager : MonoBehaviour {


	AttackMutant attack;
	 Sneak sneaking;
	public GameObject main;
	bool iscloned=false;
	public GameObject[] clone;
	GameObject Temp;

	// Use this for initialization
	void Start () {
		attack = GetComponent<AttackMutant> ();
		sneaking = GetComponent<Sneak> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (attack.attack == true) 
		{
			attack.Khatamkrde ();
			if (iscloned == false) {
				for (int i = 0; i < clone.Length; i++) {
					Temp = clone [i];
					Instantiate(Temp,transform);
					Temp.SetActive (true);
				}

				iscloned = true;
				Debug.Log (iscloned);
			} 


		} else {
			sneaking.ChaseEnemy ();
		}
	}
}
