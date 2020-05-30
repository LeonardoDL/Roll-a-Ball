using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vetor = new Vector3(15, 30, 45);
        transform.Rotate(vetor * Time.deltaTime);
    }
}
