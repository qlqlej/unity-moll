using UnityEngine;

public class Color : MonoBehaviour
{
    public GameObject go;
    MeshRenderer mr;
    UnityEngine.Color c;
   void Start()
    {
        go = GameObject.Find("Red");
        mr = go.GetComponent<MeshRenderer>();
        c = mr.material.color;
    }
   
     void Update()
    {
        c.a = 10f;
    }
}
