using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeTrigger : MonoBehaviour {

	public float totalPercent;
	public Text percentText;

	private List<ShapePlacer> placers;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		percentText.text = totalPercent.ToString () + "% Filled";
	}

	void OnTriggerExit (Collider col) {
		ShapePlacer shape = col.GetComponent<ShapePlacer> ();
		if (shape != null && !placers.Contains(shape)) {
			placers.Add (shape);
			totalPercent += shape.percentValue;
		}
	}
}
