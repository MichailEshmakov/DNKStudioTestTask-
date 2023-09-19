using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMenuShower : MonoBehaviour
{
    [SerializeField] private GameState _gameState;
    [SerializeField] private GameObject _lostMenu;

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
        _lostMenu.SetActive(true);
    }
}
