using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(1f, 0f, 0f) * Time.deltaTime);

    }
}
