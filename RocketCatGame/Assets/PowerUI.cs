using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUI : MonoBehaviour {
    public GameObject Launcher;
    private Launch LaunchRef;
    public float LaunchPowerRef;

	// Use this for initialization
	void Start () {
        LaunchRef = Launcher.GetComponent<Launch>();

	}
	
	// Update is called once per frame
	void Update () {
        LaunchPowerRef = LaunchRef.LaunchPower;
        transform.localScale = new Vector3(0.5F, (LaunchPowerRef/5) - 1, 2);
	}
}
