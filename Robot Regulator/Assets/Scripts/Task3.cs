using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public GameObject taskItemC;
    public GameObject hold;
    public GameObject itemHeld;

    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Task3":
                Pickup(col);
                if (col.tag == "Task3")
                {
                    itemHeld = taskItemC;
                }
                break;
        }
    }

    void Pickup(Collider x)
    {
        if (x.tag == "Task3")
        {
            taskItemC.transform.position = hold.transform.position;
            taskItemC.transform.parent = hold.transform;
            Debug.Log("pickupitem");

            //switch state to complete task
            this.gameObject.GetComponent<Robot>().myState = Robot.state.CompleteTask;
        }
    }
}
