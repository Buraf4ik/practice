using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveto : MonoBehaviour
{
    public GameObject beeronfinish;
    public GameObject BeerinArm;
    public GameObject robot;
    public GameObject finish;
    public GameObject target;
    private bool hold;
    private bool comeback;
  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Beer>())
        {
            hold = true;
            collision.gameObject.GetComponent<Beer>().OnHit();
        }
        if (collision.gameObject.GetComponent<finish>())
        {
            comeback = true;
            collision.gameObject.GetComponent<finish>().Finish();
        }
    }
  


    void FixedUpdate()
    {
        if (!hold) 
        {
            transform.LookAt(target.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime);
        }
        else if(!comeback)
        {
            transform.LookAt(finish.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, finish.transform.position, Time.deltaTime);
            if (robot.transform.position == finish.transform.position)
            {
               comeback = true;
               beeronfinish.SetActive(true);
               BeerinArm.SetActive(false);
            }
        }
        
    }
}
