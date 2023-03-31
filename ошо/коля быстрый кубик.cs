using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld  : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed=1;

    
    void Start()
    {
        print("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
