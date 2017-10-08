using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePlacer : MonoBehaviour {

	public GameObject shapePrefab;

	private GameObject curInstance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (curInstance != null) {
			curInstance.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 0.5f;

			if (Input.GetMouseButtonUp (0)) {
				curInstance.GetComponent<Rigidbody> ().useGravity = true;
				curInstance.GetComponent<Rigidbody> ().isKinematic = false;
				curInstance = null;
			}
		}
	}

	void OnMouseDown () {
		curInstance = Instantiate (shapePrefab, transform.position, transform.rotation, transform);
		curInstance.transform.localScale = Vector3.one;
		curInstance.transform.SetParent (null);
		curInstance.GetComponent<Rigidbody> ().useGravity = false;
		curInstance.GetComponent<Rigidbody> ().isKinematic = true;
	}
}
