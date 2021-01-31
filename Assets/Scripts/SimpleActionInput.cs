using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleActionInput : MonoBehaviour
{

    public InputActionReference input = null;


    private void Awake()
    {
        input.action.Enable();
        input.action.performed += cxt => DoThing();
    }
    
    void DoThing()
    {
        print("Did the Thing!");
    }
}
