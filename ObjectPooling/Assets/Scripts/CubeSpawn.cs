using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour {

    ObjectPooling objectPooling;

	// Use this for initialization
	private void Start () {

        objectPooling = ObjectPooling.Instance;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        objectPooling.SpawnFromPool("Cube", transform.position, Quaternion.identity);
		
	}
}
