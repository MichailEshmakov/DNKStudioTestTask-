using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _sound;
    [SerializeField] private Bird _bird;

    private void OnEnable()
    {
        _bird.Jumped += OnBirdJumped;
    }

    private void OnDisable()
    {
        _bird.Jumped -= OnBirdJumped;
    }

    private void OnBirdJumped()
    {
        _audioSource.PlayOneShot(_sound);
    }
}
