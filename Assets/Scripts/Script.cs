using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Script : MonoBehaviour
{
    // Start is called before the first frame update

    SkinnedMeshRenderer gesture;
    float time = 300;
    float timeCnt = 0;
    bool flag = false;

    void Start()
    {
    }

    // Update is called once per frame
    // m_BlendShapeWeights.Array.data[23]
    void Update()
    {
        time -= Time.deltaTime * 100;
        if(time < 0)
        {
            flag = true;
            time = 300;
            timeCnt += 1;
            GameObject.Find("Casual1_Body").GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, 99); // smile
            GameObject.Find("Casual1_Body").GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(23, 99);
            Debug.Log($"timelap --> {timeCnt}");
        }

        if(time< 100 & flag == true)
        {
            flag = false;
            GameObject.Find("Casual1_Body").GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, 0); //neutro
            GameObject.Find("Casual1_Body").GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(23, 0);
        }


    }
}
