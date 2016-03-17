using UnityEngine;
using System.Collections;

public class LogControl : MonoBehaviour {

	public bool startedLeft;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (startedLeft) {
			this.transform.position = new Vector3 (this.transform.parent.position.x, this.transform.position.y, this.transform.position.z + speed);
		} else {
			this.transform.position = new Vector3 (this.transform.parent.position.x, this.transform.position.y, this.transform.position.z - speed);
		}

		if (this.transform.position.z > 7 || this.transform.position.z < -7) {
			Destroy (this.gameObject);
		}
	}
}
