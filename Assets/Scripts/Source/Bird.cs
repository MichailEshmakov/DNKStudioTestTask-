using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _impulseForce;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // TODO: separate input
        {
            _rigidbody.AddForce(Vector2.up * _impulseForce, ForceMode2D.Impulse);
        }
    }
}
