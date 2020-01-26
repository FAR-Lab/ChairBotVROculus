using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTargetRotate : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
	{
    }

	void OnCollisionEnter(Collision other)
	{
		Debug.Log("enter");
		//if (other.collider.gameObject.CompareTag("Player"))
		//{
			transform.Rotate(0, 0, 180);
			Debug.Log("rotate");
		//}
	}
}
