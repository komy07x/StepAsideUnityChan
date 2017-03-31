using System.Collections;
using UnityEngine;

public class CubeDestroy : MonoBehaviour {

	private GameObject unitychan;

	private float difference;


	// Use this for initialization
	void Start () {

		unitychan = GameObject.Find ("unitychan");

		difference = unitychan.transform.position.z - transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (0, transform.position.y, unitychan.transform.position.z - difference);

		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "CoinTag" || other.gameObject.tag == "TrafficConeTag") {
			Destroy (other.gameObject);
		}
	}
}

