using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VRChairTriggerAnimChoreo : MonoBehaviour
{
	private Animator anim;
	public Text animtext;
	private int index = 0;
	private int N = 9;

	private GameObject chairs;

	void Start()
    {
		anim = GetComponent<Animator> ();
	}

    void Update()
    {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			index = (index - 1 + N) % N;
			PlayAnim ();
		}
		if (Input.GetKeyDown (KeyCode.Mouse1)) {
			index = (index + 1) % N;
			PlayAnim ();
		}
	}

	void PlayAnim() {
		switch (index) {
		case 0:
			animtext.text = "Chair Bot";
			break;
		case 1:
			//anim.Play ("Single01FollowMe");
			anim.CrossFade ("Single01FollowMe", 0.1f);
			animtext.text = "01 FollowMe";
			break;
		case 2:
			anim.CrossFade ("Single02IUnderstand", 0.1f);
			animtext.text = "02 IUnderstand";
			break;
		case 3:
			anim.CrossFade ("Single03IAmAvailable", 0.1f);
			animtext.text = "03 IAmAvailable";
			break;
		case 4:
			anim.CrossFade ("Single04IAmNotGoing", 0.1f);
			animtext.text = "04 IAmNotGoing";
			break;
		case 5:
			anim.CrossFade ("Single05IAmOccupied", 0.1f);
			animtext.text = "05 IAmOccupied";
			break;
		case 6:
			anim.CrossFade ("Single06IAmTrackingYou", 0.1f);
			animtext.text = "06 IAmTrackingYou";
			break;
		case 7:
			anim.CrossFade ("Single07IAmOnAMission", 0.1f);
			animtext.text = "07 IAmOnAMission";
			break;
		case 8:
			anim.CrossFade ("Single08AfterYou", 0.1f);
			animtext.text = "08 AfterYou";
			break;
		case 9:
			anim.CrossFade ("Single09IAvoidCollisions", 0.1f);
			animtext.text = "09 IAvoidCollisions";
			break;
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