using UnityEngine;
using System.Collections;

public class MinMap : MonoBehaviour {

	public GameObject target;

	void LateUpdate () {
		transform.position = target.transform.position;
		transform.eulerAngles = new Vector3(90, target.transform.eulerAngles.y);
	}
}
