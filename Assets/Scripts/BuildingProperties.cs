using UnityEngine;
using System.Collections;

public class BuildingProperties: MonoBehaviour {

	MeshRenderer buildingRender;

	public float r;
	public float g;
	public float b;

	public Vector3 parentPos;

	// Use this for initialization
	void Start () {

		r = Random.value;
		g = Random.value;
		b = Random.value;
		
		buildingRender = this.GetComponent<MeshRenderer> ();
		buildingRender.material.SetColor ("_Color", new Color(r,g,b) );
		float scaleFactor = Random.Range (1f, 2.5f);
		this.transform.localScale = new Vector3 (this.transform.localScale.x, this.transform.localScale.y, scaleFactor);
		this.transform.position = new Vector3 (this.transform.position.x, (this.transform.position.y + scaleFactor), this.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.transform.parent.position.x, this.transform.position.y, this.transform.position.z);
	}
}
