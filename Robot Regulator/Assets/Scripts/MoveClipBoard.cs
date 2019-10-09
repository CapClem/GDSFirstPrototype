using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClipBoard : MonoBehaviour
{
    //Target the clip board
    public GameObject clipBoard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //test trigger for clipboard animation
        if (Input.GetKeyDown(KeyCode.Z))
        {
            OpinClipBoard();
        }
    }

    //Change the bool on the clipboard animator to start the animation
    public void OpinClipBoard()
    {
        Animator animator = clipBoard.GetComponent<Animator>();
        {
            if (animator != null)
            {
                bool OpenClipBoard = animator.GetBool("OpenClipBoard");
                animator.SetBool("OpenClipBoard", !OpenClipBoard);
            }
        }
    }
}
