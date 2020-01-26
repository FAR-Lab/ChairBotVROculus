using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetRotate : MonoBehaviour
{
	public Transform target;

	void Start()
    {
	}

	void Update()
    {
		transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
		transform.Rotate(-90.0f, 0.0f, 0.0f);
	}
}
