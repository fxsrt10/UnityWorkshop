using UnityEngine;
using System.Collections;

public class Toggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();

			if(Physics.Raycast(ray,out hit)) {
				GameObject selected = hit.collider.gameObject;
				Debug.Log("Hit");
				selected.BroadcastMessage ("toggle");
				selected.GetComponent<MeshRenderer> ().enabled = false;
			}
		}
	}
}
