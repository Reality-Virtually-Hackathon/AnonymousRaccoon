using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeManager : MonoBehaviour {

	public Fader backdrop;
	public Fader mergeCube;
	public Fader mergeCubeOutline;

	private int counter = 0;

	// Use this for initialization
	void Start () {
		backdrop.FadeOutImmediate ();
		mergeCubeOutline.FadeOutImmediate ();
		mergeCube.FadeIn ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (counter == 0) {
				mergeCube.FadeOut (0.5f);
				mergeCubeOutline.FadeIn (0.5f);
			} else if (counter == 1) {
				// do next thing
			}
			counter++;
		}
	}
}
