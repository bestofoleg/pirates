using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animators : MonoBehaviour
{   SimpleTouchController touch;
    Rigidbody rig;
    Animator mainchar;
    float vertical;
    float horizontal;
    Vector3 lastpos;
    void Start()
    {
        touch = GetComponent<PlayerMoveController> ().leftController;
        rig = GetComponent<Rigidbody>();
        mainchar = GetComponent<Animator>();
        mainchar.SetBool("Walk",false);
    }

    // Update is called once per frame
    private void FixedUpdate()
    
    {
        if (touch.GetTouchPosition != Vector2.zero)
        {

            mainchar.SetBool("Walk", true);
        }
        else {

            mainchar.SetBool("Walk", false);
        }

        lastpos = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        /*
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal") ;


        if (rig.velocity.z >= -0.1)
        {
            mainchar.SetBool("Walk", true);

        }
        if (rig.velocity.z == 0)
            {

            mainchar.SetBool("Walk",false);
        }
        if (rig.velocity.z >= 0.1)
        {
            mainchar.SetBool("Walk",true);
        }
*/
        Debug.Log(Vector3.Distance(transform.position, lastpos));
    }

    }

