using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Altitude : MonoBehaviour {
    public int altitudeint;
    public string altitudestring;
    public Text AltitudeText;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        AltitudeText.text = altitudestring;
        altitudestring = altitudeint.ToString();
        altitudeint = ((int)GameObject.Find("Cat").transform.position.y + 4);
    }
}
