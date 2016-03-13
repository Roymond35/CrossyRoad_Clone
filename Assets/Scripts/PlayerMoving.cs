using UnityEngine;
using System.Collections;

public class PlayerMoving : MonoBehaviour {

	public float speed; 
	public int playerPosition;
	public GameObject blockHolder;

	// Use this for initialization
	void Start () {
		speed = .03f;
		playerPosition = 0;

	}

	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.transform.position.x + speed, this.transform.position.y, this.transform.position.z);
		if (this.transform.position.x > 21) {
			Destroy (this.gameObject);
		}

		//Figure this out.
		if (Input.GetKeyDown (KeyCode.W)) {
			playerPosition++;
			GameObject newPosition = GameObject.Find (playerPosition.ToString());
			this.transform.position = new Vector3 (newPosition.transform.position.x, this.transform.position.y, this.transform.position.z);

		}
		if (Input.GetKeyDown (KeyCode.S)) {
			if (playerPosition > 1) {
				playerPosition--;
				GameObject newPosition = GameObject.Find (playerPosition.ToString());
				this.transform.position = new Vector3 (newPosition.transform.position.x, this.transform.position.y, this.transform.position.z);
			}
		}


		if (Input.GetKeyDown (KeyCode.A)) {
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z-1);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z+1);
		}

		if (this.transform.position.z > 5 || this.transform.position.z < -5) {
			this.GetComponent<Rigidbody> ().isKinematic = false;
		}
		if (this.transform.position.y < -0.5) {
			Destroy (this.gameObject);
		}
	}
}
