using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSource : MonoBehaviour
{
    [SerializeField] private int _value;

    public int Value => _value;
}
