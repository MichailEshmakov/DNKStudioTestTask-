using UnityEngine;

public class LoseSoundPlayer : MonoBehaviour
{
    [SerializeField] private GameState _gameState;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;


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
        _audioSource.PlayOneShot(_audioClip);
    }
}
