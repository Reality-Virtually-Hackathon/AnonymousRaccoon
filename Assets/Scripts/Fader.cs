using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fader : MonoBehaviour {

	public Renderer[] rends;

	bool fadingIn;
	bool fadingOut;
	float curOpacity = 0f;
	float fadeSpeed = 1f;

	void Awake () {
		FadeOutImmediate ();
		rends = GetComponentsInChildren<Renderer> ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			FadeOut ();
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			FadeIn ();
		}

		if (fadingIn) {
			curOpacity += fadeSpeed * Time.deltaTime;
			if (curOpacity >= 1f) {
				curOpacity = 1f;
				fadingIn = false;
			}
			foreach (Renderer rend in rends) {
				rend.material.color = new Color (rend.material.color.r,
					rend.material.color.g,
					rend.material.color.b,
					curOpacity);
			}
		} else if (fadingOut) {
			curOpacity -= fadeSpeed * Time.deltaTime;
			if (curOpacity <= 0f) {
				curOpacity = 0f;
				fadingOut = false;
			}
			foreach (Renderer rend in rends) {
				rend.material.color = new Color (rend.material.color.r,
					rend.material.color.g,
					rend.material.color.b,
					curOpacity);
			}
		}
	}

	public void FadeIn () {
		fadingIn = true;
		fadingOut = false;
	}

	public void FadeOut () {
		fadingIn = false;
		fadingOut = true;
	}

	public void FadeOutImmediate () {
		if (rends == null) {
			rends = new Renderer[] {GetComponent<Renderer> ()};
		}

		foreach (Renderer rend in rends) {
			rend.material.color = new Color (rend.material.color.r,
				rend.material.color.g,
				rend.material.color.b,
				0f);
		}
		fadingIn = false;
		fadingOut = false;
	}
}
