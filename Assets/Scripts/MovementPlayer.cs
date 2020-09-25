using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class MovementPlayer : MonoBehaviour
{
    private float _speed = 2;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody2D.transform.Translate(- _speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody2D.transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
    }
}
