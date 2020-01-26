using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public Transform target;
	public TextMesh text3d;

	void Start()
    {
    }

    void Update()
    {
		text3d.text = System.Math.Round(target.position.x, 2) + ", " + 
			System.Math.Round(target.position.z, 2);
	}
}
