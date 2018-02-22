using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class string1 : MonoBehaviour {

	public KeyCode activateString;
	public string LockInput = "n";
	public static string releaseKey = "n";

    private Rigidbody m_Rigidbody;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

	private void Update ()
    {
		if (Input.GetKeyDown (activateString) && LockInput == "n")
        {
			LockInput = "y";

            m_Rigidbody.velocity = new Vector3 (0, 0, 2);
			StartCoroutine (RetractCollider ());

			releaseKey = "n";
		}

		if (Input.GetKeyUp (activateString))
        {
			releaseKey = "y";
		}
	}

	private IEnumerator RetractCollider()
    {
	    yield return new WaitForSeconds (0.75f);

        m_Rigidbody.velocity = Vector3.zero;

		if (releaseKey == "n")
        {
			yield return new WaitForSeconds (1);
			StartCoroutine (releaseNote ());
		}

		if (releaseKey == "y") 
		{
			StartCoroutine (releaseNote ());
		}

		LockInput = "n";
	}

	private IEnumerator releaseNote()
    {
        m_Rigidbody.velocity = new Vector3 (0, 0, -2);
		yield return new WaitForSeconds (0.75f);
        m_Rigidbody.velocity = Vector3.zero;
	}
}
