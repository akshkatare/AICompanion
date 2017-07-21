using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwapper : MonoBehaviour {

	public Material[] mats;
	SkinnedMeshRenderer rend;

	void start()
	{
		
		rend = GetComponent<SkinnedMeshRenderer> ();
		rend.enabled = true;
		rend.sharedMaterial = mats [0];
	}

	public void Show()
	{rend.sharedMaterial = mats [0];
	}


	public void Hide()
	{
		rend.sharedMaterial = mats [1];
	}

}
