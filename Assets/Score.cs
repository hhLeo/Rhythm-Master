using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    public int m_score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<GUIText>().text = "Score : " + m_score;
	}
}
