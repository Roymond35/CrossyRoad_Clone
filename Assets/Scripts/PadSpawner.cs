using UnityEngine;
using System.Collections;

public class PadSpawner : MonoBehaviour {

	GameObject pad;
	public GameObject padPrefab;
	bool started;
	public float speed;

	// Use this for initialization
	void Start () {
		pad = Instantiate (padPrefab) as GameObject;
		pad.transform.parent = this.transform;
		pad.tag = "Ground";
	}
	
	// Update is called once per frame
	void Update () {

	}
}
