using UnityEngine;
using System.Collections;

public class PadSpawner : MonoBehaviour {

	GameObject pad;
	public GameObject padPrefab;
	bool started;

	// Use this for initialization
	void Start () {
		pad = Instantiate (padPrefab) as GameObject;
		int zPos = Random.Range (-5, 6);
		pad.transform.position = new Vector3 (this.transform.position.x, pad.transform.position.y, zPos);
		pad.transform.parent = this.transform;
		pad.tag = "Ground";
	}
	
	// Update is called once per frame
	void Update () {

	}
}
