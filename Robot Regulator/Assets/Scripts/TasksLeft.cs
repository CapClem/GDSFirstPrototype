using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TasksLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject robot;
    public Text tasksLeft;

    void Update()
    {
        tasksLeft.text = "Robot Status: " + (3 - robot.GetComponent<DropItem>().tasksScored);
    }
}
