using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveCube : MonoBehaviour
{
    public Vector3 direction;
    void Start()
    {
        direction = Random.onUnitSphere;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Random.ColorHSV(0f, 1f, 1f, 1f,
        0.4f, 1f);
    }
    void Update()
    {
        transform.Translate(direction * 50.0f * Time.deltaTime);
        transform.Rotate(direction, 360.0f * Time.deltaTime);
    }
}
