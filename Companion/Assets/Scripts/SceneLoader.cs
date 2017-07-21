using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour {


	public void LoadPrototype()
	{
		SceneManager.LoadScene ("Build");
		
	}
	
	public void LoadScene()
	{SceneManager.LoadScene ("Demo Scene");
	}

	public void LoadReadMe()
	{SceneManager.LoadScene ("ReadMe");
	}
	public void LoadMenu()
	{SceneManager.LoadScene ("Menu");
	}
}
