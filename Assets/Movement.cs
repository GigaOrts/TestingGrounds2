using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private const int boundPosition = 10;
    [SerializeField] private float speed;

    private float horizontal;

    void Update()
    {
        if (transform.position.x > boundPosition)
            transform.position = new Vector3(boundPosition, transform.position.y, transform.position.z);

        if (transform.position.x < -boundPosition)
            transform.position = new Vector3(-boundPosition, transform.position.y, transform.position.z);

        horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }
}