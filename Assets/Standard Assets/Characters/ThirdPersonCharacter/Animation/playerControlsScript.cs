using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlsScript : MonoBehaviour {

	private Animator ThisAnimator = null;

	// Use this for initialization
	void Awake () {
		ThisAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float Horz = Input.GetAxis ("Horizontal");
		float Vert = Input.GetAxis ("Vertical");

		ThisAnimator.SetFloat ("Forwards", Vert);
		ThisAnimator.SetFloat ("Turn", Vert);
	}
}
