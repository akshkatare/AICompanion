﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

	[CustomEditor(typeof(FieldOfView))]
	public class DrawWireArc : Editor
	{
		void OnSceneGUI()
		{
			FieldOfView fow = (FieldOfView)target;
			Handles.color = Color.white;

			Handles.DrawWireArc (fow.transform.position, Vector3.up, Vector3.forward, 360, fow.viewRadius);

			Vector3 AngleA = fow.DirectionFromAngle (-fow.viewAngle / 2,false);
			Vector3 AngleB = fow.DirectionFromAngle (fow.viewAngle / 2,false);

			Handles.DrawLine (fow.transform.position, fow.transform.position + AngleA * fow.viewRadius);
			Handles.DrawLine (fow.transform.position, fow.transform.position + AngleB * fow.viewRadius);



		}
	}
