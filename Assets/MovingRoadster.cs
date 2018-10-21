using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MovingRoadster : MonoBehaviour
{
    private float _angle;

    public Transform MainObject;
    public float Radius = 200;
    public float Speed = 1;

    public float Angle
    {
        get { return _angle; }
        set { _angle = (value >= 360) ? 1 : value; }
    }

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        StartMove();
    }

    private void StartMove()
    {
        Angle += Speed;

        transform.position = new Vector3((float)(MainObject.position.x + Radius * Math.Cos(Math.PI * Angle / 180)), transform.position.y,
            (float)(MainObject.position.x + Radius * Math.Sin(Math.PI * Angle / 180)));

        transform.rotation = Quaternion.Euler(0, 0 - Angle + 180, 0);
    }
}