using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
             
            anim.SetBool("isRunning", true);
            transform.hasChanged = false;
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
}
