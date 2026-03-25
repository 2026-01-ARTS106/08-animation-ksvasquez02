using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    private Animator myAnimator;
    private float horizDir;
    private float vertDir;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //read from the keyboard
        horizDir = Input.GetAxis("Horizontal");
        vertDir = Input.GetAxis("Vertical");

        // use the input to send a message to the animator
        if (horizDir < 0)
        {
            myAnimator.SetInteger("direction", 3);
        }
        else if (horizDir > 0)
        {
            myAnimator.SetInteger("direction", 1);
        }
        else if (vertDir > 0)
        {
            myAnimator.SetInteger("direction", 0);
        }
        else if (vertDir < 0)
        {
            myAnimator.SetInteger("direction", 2);
        }
    }
}
