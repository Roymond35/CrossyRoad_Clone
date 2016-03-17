using UnityEngine;
using System.Collections;

public class LogSpawner : MonoBehaviour {

	public bool startLeft;
	public float MAX_SPEED; //Remember this is not inclusive.
	public float MIN_SPEED; 
	public int maxSpawns;
	public float timeDelay;
	public float ellapsedTime;
	public GameObject logPrefab;
	private Vector3 prefabPosition;
	private float zCoord;
	private Vector3 spawnPosition;
	private float speed;


	// Use this for initialization
	void Start () {
		startLeft = Random.value > 0.5f;
		if (startLeft) {
			spawnPosition = new Vector3 (-7.0f, 0.5f, -6.0f);
		} else {
			spawnPosition = new Vector3 (-7.0f, 0.5f, 6.0f);
		}
		ellapsedTime = 0;
		timeDelay = Random.Range (1f, 2.5f);
		speed = Random.Range (MIN_SPEED, MAX_SPEED);
	}
	
	// Update is called once per frame
	void Update () {
		int numLogs = this.transform.childCount;
		ellapsedTime += Time.deltaTime;
		if (ellapsedTime > timeDelay && numLogs < maxSpawns) {
			ellapsedTime = 0;
			int logWidth = Random.Range (1, 4);
			GameObject newBlock = Instantiate (logPrefab) as GameObject;
			newBlock.transform.localScale = new Vector3 (logPrefab.transform.localScale.x, logPrefab.transform.localScale.y, logWidth);
			if (startLeft) {
				zCoord = spawnPosition.z - float.Parse (logWidth.ToString()) / 2;
			} else {
				zCoord = spawnPosition.z + float.Parse (logWidth.ToString()) / 2;
			}
			newBlock.transform.position = new Vector3 (spawnPosition.x, spawnPosition.y, zCoord);
			newBlock.GetComponent<LogControl> ().startedLeft = this.startLeft;
			newBlock.GetComponent<LogControl> ().speed = this.speed;
			newBlock.transform.parent = this.transform;
		}
		
	}
}
