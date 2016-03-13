using UnityEngine;
using System.Collections;

public class MoveBlock : MonoBehaviour {

	public float speed;
	public bool started = false;
	public int counter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (started) {
			this.transform.position = new Vector3 (this.transform.position.x + speed, this.transform.position.y, this.transform.position.z);
		}
		if (this.transform.position.x > 21) {
			Destroy (this.gameObject);
		}
	}
}
