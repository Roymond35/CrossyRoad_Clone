using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {

	public float speed;
	public float carSpeed;
	public bool started = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (started) {
			this.transform.position = new Vector3 (this.transform.position.x + speed, this.transform.position.y, this.transform.position.z + carSpeed);
		}
		if (this.transform.position.z > 6) {
			Destroy (this.gameObject);
		}
	}
}
