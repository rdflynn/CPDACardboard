using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public GameObject objectToRotate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		objectToRotate.transform.Rotate(Vector3.right * (Time.deltaTime*10.0f));
		objectToRotate.transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}
