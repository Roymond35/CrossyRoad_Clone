using UnityEngine;
using System.Collections;

public class SpawnBuilding : MonoBehaviour {

	public GameObject buildingPrefab;

	// Use this for initialization
	void Start () {

		if (Random.value > 0.5) {
			Vector3 spawnPosition = new Vector3 (-7.0f, 0.5f, -6.0f);
			GameObject newBlock = Instantiate (buildingPrefab) as GameObject;
			newBlock.transform.position = spawnPosition;
			newBlock.transform.parent = this.transform;
		}
		if (Random.value > 0.5) {
			Vector3 spawnPosition = new Vector3 (-7.0f, 0.5f, 6.0f);
			GameObject newBlock = Instantiate (buildingPrefab) as GameObject;
			newBlock.transform.position = spawnPosition;
			newBlock.transform.parent = this.transform;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
