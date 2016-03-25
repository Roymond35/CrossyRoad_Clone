using UnityEngine;
using System.Collections;

public class SpawnCar : MonoBehaviour {

	public bool startLeft;
	public float MAX_SPEED; //Remember this is not inclusive.
	public float MIN_SPEED; 
	public int maxSpawns;
	public float timeDelay;
	public float ellapsedTime;
	public GameObject carPrefab;
	private Vector3 prefabPosition;
	private float zCoord;
	public Vector3 spawnPosition;
	private float speed;


	// Use this for initialization
	void Start () {
		//Default Values in case nothing gets set.
		MAX_SPEED = 0.1f;
		MIN_SPEED = 0.05f;
		maxSpawns = 3;

		startLeft = Random.value > 0.5f;
		if (startLeft) {
			spawnPosition = new Vector3 (-7.0f, 1f, -6.0f);
		} else {
			spawnPosition = new Vector3 (-7.0f, 1f, 6.0f);
		}
		ellapsedTime = 0;
		timeDelay = Random.Range (1f, 2.5f);
		speed = Random.Range (MIN_SPEED, MAX_SPEED);
	}

	// Update is called once per frame
	void Update () {
		int numCars = this.transform.childCount;
		ellapsedTime += Time.deltaTime;
		if (ellapsedTime > timeDelay && numCars < maxSpawns) {
			ellapsedTime = 0;
			GameObject newBlock = Instantiate (carPrefab) as GameObject;
			newBlock.transform.position = spawnPosition;
			newBlock.GetComponent<CarControl> ().startedLeft = this.startLeft;
			if (!startLeft) {
				Vector3 rot = newBlock.transform.rotation.eulerAngles;
				rot = new Vector3 (rot.x, rot.y + 180, rot.z);
				newBlock.transform.rotation = Quaternion.Euler (rot);
			}
			newBlock.GetComponent<CarControl> ().speed = this.speed;
			newBlock.transform.parent = this.transform;
		}

	}

	void OnCollisionEnter(Collision c){
		Debug.Log (c.gameObject.name);
	}
}
