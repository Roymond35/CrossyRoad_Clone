using UnityEngine;
using System.Collections;

public class SpawnCar : MonoBehaviour {

	public GameObject carPrefab;
	public Vector3 spawnPosition;
	public int timeDelay;
	public float ellapsedTime;


	// Use this for initialization
	void Start () {
		ellapsedTime = 0;
	}
	
	// Update is called once per frame
	void Update () {

		ellapsedTime += Time.deltaTime;
		spawnPosition = new Vector3 (this.transform.position.x, spawnPosition.y, spawnPosition.z);
		if (ellapsedTime > timeDelay) {
			ellapsedTime = 0;
			GameObject newBlock = Instantiate (carPrefab) as GameObject;
			newBlock.transform.position = spawnPosition;
			newBlock.GetComponent<CarControl> ().speed = .03f;
			newBlock.GetComponent<CarControl> ().carSpeed = 0.05f;
			newBlock.GetComponent<CarControl> ().started = true;
		}
	}
}
