using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChangingSoundPlayer : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;


    private void OnEnable()
    {
        _score.Changed += OnScoreChanged;
    }

    private void OnDisable()
    {
        _score.Changed -= OnScoreChanged;
    }

    private void OnScoreChanged()
    {
        _audioSource.PlayOneShot(_audioClip);
    }
}
