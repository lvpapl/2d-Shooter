using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	private Vector3 target;
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = gameObject.transform;
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)-GameObject.FindGameObjectWithTag("Player").transform.position;
		//myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
		                                       // Quaternion.LookRotation(target-myTransform.position),
		                                       // Time.deltaTime * 100);

	}
}
