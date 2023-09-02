using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Text score;
    public Transform camera;
    public Rigidbody rigidbody;
    public Transform player;
    public Vector3 x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(0, 0, 1200*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(8000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-8000 * Time.deltaTime, 0, 0);
        }
        score.text=((player.position.z)+484.1).ToString("0");
        camera.position = player.position+x;
    }
}
