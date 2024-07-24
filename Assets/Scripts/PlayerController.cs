using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigid;

    [SerializeField] private float moveSpeed;

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigid.MovePosition(transform.position + new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0));
    }
}
