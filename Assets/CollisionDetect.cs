using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CollisionDetect : MonoBehaviour {

	// Use this for initialization
	private void OnParticleCollision(GameObject other)
	{
		Debug.Log(other.name);
	}


	
	
}
