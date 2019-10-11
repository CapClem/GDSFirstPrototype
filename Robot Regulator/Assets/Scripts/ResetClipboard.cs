using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetClipboard : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clipBoard;
    
    void OnTriggerEnter(Collider y)
    {

        //checks if player collides with Trash collider
        if (y.tag == "ResetLocation")
        {
            clipBoard.GetComponent<MoveClipBoard>().OpinClipBoard();
            Debug.Log("Open clipboard");
        }
    }
}