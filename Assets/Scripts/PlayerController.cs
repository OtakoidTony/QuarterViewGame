using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    Rigidbody rigidbody;

    Vector3 movement;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Right Analog Horizontal") + Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Right Analog Vertical") + Input.GetAxisRaw("Vertical");
        Run(h, v);
    }

    void Run(float h, float v)
    {
        movement.Set(h, 0, v); // ℝ^3 Vector movement의 값을 (h, 0, v)로 설정.

        // .normalized는 크기가 1인 방향벡터를 반환.
        movement = movement.normalized * speed * Time.deltaTime;
        // movement를 (h, 0, v)의 방향벡터를 speed만큼 곱한걸 dt 만큼 곱한 값으로 설정.

        rigidbody.MovePosition(transform.position + movement);
        // rigidbody의 위치를 원래 위치에서 movement의 값만큼 더함.

        //Gamepad.current.SetMotorSpeeds(0.25f, 0.75f);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
                
    }
}
