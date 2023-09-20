using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _value;

    public int Value => _value;

    public event Action Changed;

    public void ChangeBy(int delta)
    {
        _value += delta;
        Changed?.Invoke();
    }
}
