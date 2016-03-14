using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cube : MonoBehaviour
{
    //private float m_time = 0.0f;
    private int count = 0;  //update的次数
    private int pers = 60;  //每秒的帧数（每秒一个节拍）
    //private int loop;       //手势数*pers
    private string[] constant = { "Prefabs/CubeLeft", "Prefabs/CubeRight", "Prefabs/CubeUp", "Prefabs/CubeDown", "Prefabs/CubeClockWise", "Prefabs/CubeAnticlockWise", "Prefabs/CubeRightLeft", "Prefabs/CubeLeftRight" };

    // Use this for initialization
    void Start()
    {
        //Debug.Log(Time.deltaTime);    //output?
        //loop = 8 * pers;
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        //m_time += Time.deltaTime;
        //注意：由于显示的图片为倒立镜像，此处显示的cube中，left和right颠倒，up和down颠倒，其他正确
        if (count % pers == 0)
        {
            //产生随机数
            //在原来的位置复制出一个匀速运动的Cube
            GameObject obj = Instantiate(Resources.Load(constant[Random.Range(0, 8)])) as GameObject;
        }
/*        if (count % loop == 0)  //隔一段时间
        {
            //在原来的位置复制出一个匀速运动的CubeLeft（左）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeLeft")) as GameObject;
        }
        if (count % loop == pers)
        {
            //在原来的位置复制出一个匀速运动的CubeRight（右）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeRight")) as GameObject;
        }
        if (count % loop == 2 * pers)
        {
            //在原来的位置复制出一个匀速运动的CubeUp（前）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeUp")) as GameObject;
        }
        if (count % loop == 3 * pers)
        {
            //在原来的位置复制出一个匀速运动的CubeDown（后）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeDown")) as GameObject;
        }
        if (count % loop == 4 * pers)
        {
            //在原来的位置复制出一个匀速运动的CubeClockWise（顺时针）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeClockWise")) as GameObject;
        }
        if (count % loop == 5 * pers)
        {
            //在原来的位置复制出一个匀速运动的CubeAnticlockWise（逆时针）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeAnticlockWise")) as GameObject;
        }
        if (count % loop == 6 * pers)
        {
            //在原来的位置复制出一个匀速运动的CubeRightLeft（右左）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeRightLeft")) as GameObject;
        }
        if (count % loop == 7 * pers)
        {
            //在原来的位置复制出一个匀速运动的CubeLeftRight（左右）
            GameObject obj = Instantiate(Resources.Load("Prefabs/CubeLeftRight")) as GameObject;
        }
*/         
        //transform.Translate(0f, 0f, -2f * Time.deltaTime);
    }
}
