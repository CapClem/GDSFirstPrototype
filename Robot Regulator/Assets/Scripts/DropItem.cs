using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropItem : MonoBehaviour
{
    //attched GameObject Task1Paper in scene view
    public GameObject paper;

    //attched GameObject Task2Box in scene view
    public GameObject box2;

    //attched GameObject Task3Box in scene view
    public GameObject box3;

    //locate each button
    public Button task1Button;
    public Button task2Button;
    public Button task3Button;

    void OnTriggerEnter(Collider y)
    {

        //checks if player collides with Trash collider
        if (y.tag == "Trash")
        {

            //checks if player is holding GameObject paper
            if (paper != null && !paper.Equals(null))
            {

                //if holding paper this destroys GameObject paper
                Destroy(paper);
                Debug.Log("Completed Task 1!");
                //turn the button off & change color
                task1Button.GetComponent<Image>().color = Color.red;
                task1Button.interactable = false;

            }

            //checks if player is holding GameObject box2
            else if (box2 != null && !box2.Equals(null))
            {

                //if holding box2 this destroys GameObject paper
                Destroy(box2);
                Debug.Log("Completed Task 2!");
                //turn the button off & change color
                task2Button.GetComponent<Image>().color = Color.red;
                task2Button.interactable = false;
            }

            //checks if player is holding GameObject box3
            else if (box3 != null && !box3.Equals(null))
            {

                //if holding box3 this destroys GameObject paper
                Destroy(box3);
                Debug.Log("Completed Task 3!");
                //turn the button off & change color
                task3Button.GetComponent<Image>().color = Color.red;
                task3Button.interactable = false;
            }

            //after completing task reset robot
            this.gameObject.GetComponent<Robot>().myState = Robot.state.Reset;
        }       
    }    
}
