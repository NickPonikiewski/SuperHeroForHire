using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int playerSpeed = 10;
	public bool facingRight = true;
	public float moveX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();
	}
	void PlayerMove(){
		//controls
		moveX = Input.GetAxis("Horizontal");
		//player Dir
		if (moveX < 0.0f && facingRight == false) {
			FlipPlayer ();
		} else if (moveX > 0.0f)
		//phy
	}
	void FlipPlayer(){
		
	}
}
