using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public event Action OnOver;

    public void Loose() // TODO: separate interfaces
    {
        OnOver?.Invoke();
    }
}
