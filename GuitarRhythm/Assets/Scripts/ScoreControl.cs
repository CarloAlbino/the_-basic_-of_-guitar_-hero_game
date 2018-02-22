using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TextMesh))]
public class ScoreControl : MonoBehaviour {

    private TextMesh m_ScoreDisplay;
    
	void Start ()
    {
        m_ScoreDisplay = GetComponent<TextMesh>();
	}

	void Update ()
    {
        m_ScoreDisplay.text = "Score :" + GameController.totalscore;
	}
}
