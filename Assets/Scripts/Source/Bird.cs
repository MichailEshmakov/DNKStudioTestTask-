using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _impulseForce;

    public event Action Jumped;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.AddForce(Vector2.up * _impulseForce, ForceMode2D.Impulse);
            Jumped?.Invoke();
        }
    }
}
