using UnityEngine;
using System.Collections;

public class CubeAnticlockWise : MonoBehaviour {
    private float m_time = 0.0f;

    // Use this for initialization
    void Start()
    {
        m_time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;
        //transform.Translate(0f, 0f, -6f * Time.deltaTime);
        transform.Translate(0f, 0f, -Random.Range(6.1f, 8.1f) * Time.deltaTime);
        if (transform.position.z < -35.0f)
        {
            Destroy(gameObject);
        }
    }
}
