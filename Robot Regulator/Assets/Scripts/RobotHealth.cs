using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotHealth : MonoBehaviour
{
    public Slider robotHealthBar;
    public GameObject robot; 


    // Start is called before the first frame update
    void Start()
    {
        robotHealthBar.value = 3;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void decreaseHealth()
    {
        robotHealthBar.value -= 1;
        robot.GetComponent<DropItem>().failedTasks = robot.GetComponent<DropItem>().failedTasks += 1; 
    }

    
}
