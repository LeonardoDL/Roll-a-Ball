using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showcase : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Debug.Log("This is a Log");
        if (Input.GetKeyDown(KeyCode.S))
            Debug.LogWarning("This is a Warning");
        if (Input.GetKeyDown(KeyCode.D))
            Debug.LogError("This is an Error");
    }
}
