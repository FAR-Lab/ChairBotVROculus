using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VRChairTriggerAnimLookNoAnim : MonoBehaviour
{
	public Transform target;

	private bool look = false;

	void Start()
    {
	}

    void Update()
    {
		//play idle animation if not clicked, look at observer if clicked.
		if (OVRInput.GetUp(OVRInput.Button.Two)) {  //B cutton on Quest.
			look = !look;
			Debug.Log("look: " + look);
		}
		if (look)
		{
			transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
			transform.Rotate(-90.0f, 0.0f, 0.0f);
		}
	}

	void OnCollisionEnter(Collision other) {
		Debug.Log("enter");
		if (other.collider.gameObject.CompareTag ("Player")) {
			transform.Rotate(0, 0, 180);
			Debug.Log("rotate");
		}
	}
}