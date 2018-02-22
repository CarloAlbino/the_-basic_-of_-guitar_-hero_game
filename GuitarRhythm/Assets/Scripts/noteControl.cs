using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteControl : MonoBehaviour {

	public Transform sucessbust;
	public Transform failbust;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "failcollder") 
		{
			Destroy (gameObject);
			Debug.Log("Fail!!");
			Instantiate (failbust, transform.position, failbust.rotation);
			GameController.totalscore -= 1;
		}
		if (other.gameObject.name == "sucess") 
		{
			Debug.Log ("sucess1 hit");
			Destroy (gameObject);
			Instantiate (sucessbust, transform.position, sucessbust.rotation);
			GameController.winStreak += 1;
			GameController.totalscore += 10;
		}
		
	}
}
