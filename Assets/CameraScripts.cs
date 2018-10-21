using UnityEngine;
using System.Collections;

public class CameraScripts : MonoBehaviour {
	public int speed = 10;//Наша скорость

	void Update () {
	if (Input.GetKey (KeyCode.W)) {
			gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
				}
		if (Input.GetKey (KeyCode.S)) {
			gameObject.transform.position -= gameObject.transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			gameObject.transform.position -= gameObject.transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {
			gameObject.transform.position += gameObject.transform.right * speed * Time.deltaTime;
		}
	}
}
