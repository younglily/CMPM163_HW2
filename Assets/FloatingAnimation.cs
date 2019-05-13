using UnityEngine;
using System.Collections;

public class FloatingAnimation : MonoBehaviour
{
    // User Inputs
    float originalY;

    public float floatStrength = 1;


    // Use this for initialization
    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, originalY + ((float)System.Math.Sin(Time.time) * floatStrength), transform.position.z);
    }
}
