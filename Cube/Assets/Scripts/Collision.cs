using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag=="Finish")
        {
            FindObjectOfType<Manager>().win();
        }
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<Manager>().lose();
        }
    }
    public void OnCollisionExit(UnityEngine.Collision collision)
    {
        if(collision.contacts.Count()==0)
        {
            FindObjectOfType<Manager>().lose();
        }
    }
}
