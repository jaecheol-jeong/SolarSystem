using UnityEngine;
using System.Collections;

public class mainScript : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate( 0, 2 * speed * Time.deltaTime, 0);
	}
}
