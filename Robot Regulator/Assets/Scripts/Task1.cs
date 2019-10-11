using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public GameObject taskItemA;
    public GameObject hold;
    public GameObject itemHeld;
    
    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Task1":
            Pickup(col);
            if(col.tag == "Task1")
            {
              itemHeld = taskItemA;
            }
            break;
        }
    }

    void Pickup(Collider x)
    {
        if (x.tag == "Task1")
        {
            taskItemA.transform.position = hold.transform.position;
            taskItemA.transform.parent = hold.transform;
            Debug.Log("pickupitem");

            //switch state to complete task
            this.gameObject.GetComponent<Robot>().myState = Robot.state.CompleteTask;
        }       
    }  
}

