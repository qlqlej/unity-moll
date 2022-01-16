using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.0f;
    void Start()
    {
        speed = Random.Range(20.0f, 100.0f);
    }
    void Update()
    {
        transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
    }

}
