using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArrowBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMove(InputValue input)
    {
        Debug.Log("Moving: " + input.ToString());
    }

    private void OnBoost(InputValue input)
    {
        Debug.Log("Boosting: " + input.ToString());
    }

    private void OnStall(InputValue input)
    {
        Debug.Log("Stalling: " + input.ToString());
    }
}
