using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;
    float vAxis;


    public float speed;


    Vector3 moveVec;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Right Analog Horizontal") + Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Right Analog Vertical") + Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;
    }
}
