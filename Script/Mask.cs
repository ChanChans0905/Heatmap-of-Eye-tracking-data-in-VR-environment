using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public GameObject[] MaskOjb;
    void Start()
    {
        for(int i = 0;  i < MaskOjb.Length; i++)
        {
            MaskOjb[i].GetComponent<MeshRenderer>().material.renderQueue = 3002;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
