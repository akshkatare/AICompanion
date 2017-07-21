using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneKey : MonoBehaviour {

	public GameObject Wolf;
	public GameObject enemy;
	public GameObject enemy2;
	public GameObject StartText;

	void FixedUpdate()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			{
				loadMenu();
			}
		if(Input.GetKeyDown(KeyCode.Q))
		{
			StartScene();
		}
	}

	void loadMenu()
	{
		SceneManager.LoadScene ("Menu");
			}

	void StartScene()
	{
		Wolf.GetComponent<UnityEngine.AI.NavMeshAgent> ().enabled = true;
				enemy.GetComponent<UnityEngine.AI.NavMeshAgent> ().enabled = true;
				enemy2.GetComponent<UnityEngine.AI.NavMeshAgent> ().enabled = true;
		Wolf.GetComponent<Animator>().SetBool("Creep",true);
		StartText.SetActive (false);
			}
}
