using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	BoxCollider spawnBlock;
	bool blockIn;
	int counter;
	public GameObject[] desiredBlocks;
	GameObject newBlock;
	public Transform blockHolder;


	// Use this for initialization
	void Start () {
		blockIn = false;
		counter = -1;
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.tag != "Player") {
			blockIn = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if (!blockIn) {
			int nextNum = Random.Range (0, desiredBlocks.Length);
			if (counter > 1) {
				newBlock = Instantiate (desiredBlocks [nextNum]) as GameObject;
			} else {
				newBlock = Instantiate (desiredBlocks [0]) as GameObject;
			}
			counter++;
			newBlock.transform.parent = blockHolder;
			newBlock.GetComponent<MoveBlock> ().speed = .03f;
			newBlock.GetComponent<MoveBlock> ().started = true;
			newBlock.GetComponent<MoveBlock> ().counter = this.counter;
			newBlock.name = this.counter.ToString ();
			blockIn = true;

		}
	}
}
