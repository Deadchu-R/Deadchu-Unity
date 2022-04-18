using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public float speed;
    public Vector3 point1;
    public Vector3 point2;
    private Vector3 direction;
    private bool isGoingToPoint2;

    // Start is called before the first frame update
    void Start()
    {
        direction = (point2 - point1).normalized;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
