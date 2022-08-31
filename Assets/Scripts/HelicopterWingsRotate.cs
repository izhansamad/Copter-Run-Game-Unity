using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterWingsRotate : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 500 * Time.deltaTime, 0);
    }
}
