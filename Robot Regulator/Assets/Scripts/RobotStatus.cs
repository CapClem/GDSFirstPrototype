using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotStatus : MonoBehaviour
{
    public GameObject robot;
    public Text status;

    // Update is called once per frame
    void Update()
    {
        status.text = "Robot Status: " + robot.GetComponent<Robot>().currentStatus;   
    }
}
