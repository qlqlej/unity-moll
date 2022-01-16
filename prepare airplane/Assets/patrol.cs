using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    float rightMax = 2.0f; //좌로 이동가능한 (x)최대값
    float leftMax = -2.0f; //우로 이동가능한 (x)최대값
    float currentPosition; //현재 위치(x) 저장
    float direction = 3.0f; //이동속도+방향

    void Start()
    {
        currentPosition = transform.position.x;
    }

    void Update()
    {
        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= rightMax)
        {
            direction *= -1;
            currentPosition = rightMax;
        }


        else if (currentPosition <= leftMax)

        {

            direction *= -1;

            currentPosition = leftMax;

        }


        transform.position = new Vector3(currentPosition, 0, 0);

    }
}
