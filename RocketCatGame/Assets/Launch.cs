using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public float LaunchRotation;
    public float LaunchPower;
    public bool canRotate = true;
    public bool powerSelectMode = false;
    public bool isFalling;

    public Rigidbody2D CatRigid;

    // Use this for initialization
    void Start()
    {
        Physics2D.autoSimulation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canRotate == true)
        {
            LaunchRotation = (Mathf.Sin(Time.time * 2) * 1);
            transform.Rotate(Vector3.forward * (LaunchRotation * 2));
        }
        if (powerSelectMode == true)
        {
            LaunchPower = (Mathf.Sin(Time.time * 8) * 40);
            LaunchPower = Mathf.Clamp(LaunchPower, 5, 40);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canRotate == true)
            {
                canRotate = false;
                powerSelectMode = true;
            }
            if (Time.timeScale == 0) {
                Application.Quit();
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (powerSelectMode == true)
            {
                powerSelectMode = false;
                Physics2D.autoSimulation = true;
                CatRigid.AddForce(transform.right * LaunchPower, ForceMode2D.Impulse);
            }
        }

        if (CatRigid.velocity.y < 0)
        {
            StartCoroutine(BlinkTimer());
        }
    }

    IEnumerator BlinkTimer()
    {

        yield return new WaitForSeconds(3);
        Time.timeScale = 0;

    }
}