using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLoosingSwitcher : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> _behaviours; // TODO: use switchable

    private GameState _gameState;

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
        _behaviours.ForEach(behaviour => behaviour.enabled = false);
    }
}
