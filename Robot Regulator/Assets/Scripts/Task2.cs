using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public GameObject taskItemB;
    public GameObject hold;
    public GameObject itemHeld;

    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Task2":
            Pickup(col);
            if (col.tag == "Task2")
            {
               itemHeld = taskItemB;
            }
            break;
        }
    }

    void Pickup(Collider x)
    {
        if (x.tag == "Task2")
        {
            taskItemB.transform.position = hold.transform.position;
            taskItemB.transform.parent = hold.transform;
            Debug.Log("pickupitem");

            //switch state to complete task
            this.gameObject.GetComponent<Robot>().myState = Robot.state.CompleteTask;
        }
    }
}
