using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectsX : MonoBehaviour
{
    /// <summary>
    /// Bomba para ve balonu döndürmek için 
    /// </summary>

    public float spinSpeed;

    
    void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }
}
