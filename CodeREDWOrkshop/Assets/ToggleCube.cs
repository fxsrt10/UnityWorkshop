using UnityEngine;
using System.Collections;

public class ToggleCube : MonoBehaviour {
	public GameObject x;
	public GameObject o;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void toggle () {
		if (x.GetComponent<MeshRenderer> ().enabled == true) {
			x.GetComponent<MeshRenderer> ().enabled = false;
			o.GetComponent<MeshRenderer> ().enabled = true;
		} 
		else if(x.GetComponent<MeshRenderer> ().enabled == false && o.GetComponent<MeshRenderer> ().enabled == false) {
			x.GetComponent<MeshRenderer> ().enabled = false;
			o.GetComponent<MeshRenderer> ().enabled = true;
		}
		else {
			
			x.GetComponent<MeshRenderer> ().enabled = true;
			o.GetComponent<MeshRenderer> ().enabled = false;
			}

	}
}
