using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	private bool facingRight = false;

	private Transform myTransform;

	void Awake(){
		myTransform = transform;
	}
	// https://www.youtube.com/watch?v=O8-oZfi4utY&index=3&list=PLE5C2870574BF4B06
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		target = go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FlipPlayer(){
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
}
