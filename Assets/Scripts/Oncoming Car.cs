using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingCar : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the car forward in a straight line
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
