using UnityEngine;
using System.Collections;

public class SpawnCar : MonoBehaviour {

	public GameObject carPrefab;
	public Vector3 spawnPosition;
	public float timeDelay;
	public float ellapsedTime;
	public bool movingLeft;
	public float carSpeed;
	public const int MAX_CARS = 3;


	// Use this for initialization
	void Start () {
		ellapsedTime = 0;
		timeDelay = Random.Range (1f, 2.5f);
		carSpeed = Random.Range (0.01f, 0.09f);
	}
	
	// Update is called once per frame
	void Update () {
		int numberCars = this.transform.childCount;
		ellapsedTime += Time.deltaTime;
		spawnPosition = new Vector3 (this.transform.position.x, spawnPosition.y, spawnPosition.z);
		if (ellapsedTime > timeDelay && numberCars < MAX_CARS) {
			ellapsedTime = 0;
			GameObject newBlock = Instantiate (carPrefab) as GameObject;
			newBlock.transform.position = spawnPosition;
			//newBlock.GetComponent<CarControl> ().speed = .03f;
			newBlock.GetComponent<CarControl> ().carSpeed = this.carSpeed;
			newBlock.GetComponent<CarControl> ().movingLeft = this.movingLeft;
			if (!movingLeft) {
				Vector3 rot = newBlock.transform.rotation.eulerAngles;
				rot = new Vector3(rot.x,rot.y+180,rot.z);
				newBlock.transform.rotation = Quaternion.Euler(rot);
			}
			newBlock.GetComponent<CarControl> ().started = true;
			newBlock.transform.parent = this.transform;
		}
	}
}
