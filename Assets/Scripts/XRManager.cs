using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class XRManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName == "MockHMDDisplay")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
