using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderofexecution : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake Call");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable Call");
    }

    private void Reset()
    {
        Debug.Log("Reset Call");
    }
}
