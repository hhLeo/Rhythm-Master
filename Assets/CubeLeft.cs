using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeLeft : MonoBehaviour {
    private float m_time = 0.0f;    //runtime

	// Use this for initialization
	void Start () {
        m_time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        m_time += Time.deltaTime;   //每一帧Time.deltaTime是常数，为1/60
        //transform.Translate(0f, 0f, -6f * Time.deltaTime);  //坐标变化
        transform.Translate(0f, 0f, -Random.Range(6.1f, 8.1f) * Time.deltaTime);
        if (transform.position.z < -35.0f)
        {
            Destroy(gameObject);    //销毁一个Cube
        }

        //GameObject.Find("ScoreDisplay").GetComponent<ScoreDisplay>().m_score++;//?
	}
}
