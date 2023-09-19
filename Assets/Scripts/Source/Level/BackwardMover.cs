using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackwardMover : MonoBehaviour
{
    [SerializeField] private Speed _speed;
    [SerializeField] private Transform _transform;
    [SerializeField] private float _speedCoefficient;

    private void Awake()
    {
        _speed = FindObjectOfType<Speed>(); // TODO: init
    }

    private void Update()
    {
        _transform.Translate(Vector2.left * _speed.Value * _speedCoefficient * Time.deltaTime);
    }
}
