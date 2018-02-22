using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note2xControl : MonoBehaviour {

	public Transform sucessbust;
	public Transform failbust;
	public int noteHp = 10;

	void Update ()
    {
        if(noteHp < 1)
        {
            Debug.Log ("sucess1 hit");
            Destroy (gameObject);
            Instantiate (sucessbust, transform.position, sucessbust.rotation);
            GameController.winStreak += 1;
        }
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "failcollder") 
		{
			Destroy (gameObject);
			Debug.Log("Fail!!");
			Instantiate (failbust, transform.position, failbust.rotation);
		}
	}

    void OnTriggerStay( Collider other)
    { 
        if (other.gameObject.name == "sucess" && string1.releaseKey == "n") 
        {
            noteHp -= 1;
        }
    }
}
