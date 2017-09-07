using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMoving : MonoBehaviour {

		public float moveSpeed;

	// Use this for initialization
	void Start () {

		float moveSpeed = 4f;

	}
	
	// Update is called once per frame
	void Update () {

		float move = Input.GetAxisRaw ("Vertical") * 2;
		transform.Translate (move, 0, 0);

		
	}
}
