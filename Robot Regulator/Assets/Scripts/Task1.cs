using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public GameObject taskItem;
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
                    itemHeld = taskItem;
                }
            break;
        }
    }

    void Pickup(Collider x)

    {
        if (x.tag == "Task1")
        {
            taskItem.transform.position = hold.transform.position;
            taskItem.transform.parent = hold.transform;
            Debug.Log("pickupitem");
        }
        else if (x.tag == "Trash" && itemHeld != null)
        {
            Destroy(taskItem);
            Debug.Log("DestoyItem");
            
        }
        else {
            Debug.Log("fuck");
        }
    }
}

