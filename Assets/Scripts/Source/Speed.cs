using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    [SerializeField] [Min(0.01f)] private float _value;

    public float Value => _value;
}
