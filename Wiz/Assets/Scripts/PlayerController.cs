using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 50.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 50.0f;
        Vector3 vector = transform.position;
        Debug.Log (vector);
        if ((vector.x <= 20.0) && (vector.x >= -20.0))
        {
            transform.Translate(x, 0, 0);
        }
        if (vector.x < -20)
        {
            transform.Translate(1, 0, 0);
        }
        if (vector.x > 20)
        {
            transform.Translate(-1, 0, 0);
        }
        if ((vector.z <= 20.0) && (vector.z >= -20.0))
        {
            transform.Translate(0, 0, z);
        }
        if (vector.z < -20)
        {
            transform.Translate(0, 0, 1);
        }
        if (vector.z > 20)
        {
            transform.Translate(0, 0, -1);
        }

        // transform.Translate(0, 0, z);
        // transform.Translate(x, 0, 0);
    }
}