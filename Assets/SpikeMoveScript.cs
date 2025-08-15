using System;
using UnityEngine;

public class SpikeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("this is a test");
        print("hi");
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        


    }
}
