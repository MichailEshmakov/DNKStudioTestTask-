using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLoosingRigidbodySwitcher : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody; 

    private GameState _gameState; // TODO: Use pauser instead

    private void Awake()
    {
        _gameState = FindObjectOfType<GameState>(); // TODO: init
    }

    private void OnEnable()
    {
        _gameState.OnOver += OnGameOver;
    }

    private void OnDisable()
    {
        _gameState.OnOver -= OnGameOver;
    }

    private void OnGameOver()
    {
        _rigidbody.simulated = false;
    }
}
