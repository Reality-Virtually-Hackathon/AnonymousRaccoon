using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeManager : MonoBehaviour {

	public Fader backdrop;
	public Fader mergeCube;
	public Fader mergeCubeOutline;

	// Use this for initialization
	void Start () {
		backdrop.FadeOutImmediate ();
		mergeCubeOutline.FadeOutImmediate ();
		mergeCube.FadeIn ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			backdrop.FadeIn ();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			mergeCube.FadeOut (0.5f);
			mergeCubeOutline.FadeIn (0.5f);
		}

	}
}
