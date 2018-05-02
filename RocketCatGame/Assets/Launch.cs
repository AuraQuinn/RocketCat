using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {
    public float LaunchRotation;
    public float LaunchPower;
    public bool canRotate = true;
    public bool canLaunch = false;


	// Use this for initialization
	void Start () {
        Physics2D.autoSimulation = false;
    }

    // Update is called once per frame
    void Update () {
        if (canRotate == true)
        {
            LaunchRotation = (Mathf.Sin(Time.time * 2) * 1);
            transform.Rotate(Vector3.forward * (LaunchRotation * 2));
        }
        if (canLaunch == true)
        {
            LaunchPower = (Mathf.Sin(Time.time * 8) * 1);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canRotate == true)
            {
                canRotate = false;
                canLaunch = true;
            }
            else if (canLaunch == true)
            {
                canLaunch = false;
                Physics2D.autoSimulation = true;
            }
        }
	}
}
