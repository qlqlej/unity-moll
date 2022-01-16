using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ExplosiveCube cube;
    void OnMouseDown()
    {
        for (int i = 0; i < 100; i++)
        {
            ExplosiveCube obj = Instantiate<ExplosiveCube>(cube,
            transform.position, transform.rotation);
            Destroy(obj.gameObject, 1.0f);
        }
    }
}
