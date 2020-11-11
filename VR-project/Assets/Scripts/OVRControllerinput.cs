using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRControllerinput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("右人差し指トリガーを押したよ！");
        }
    }
}
