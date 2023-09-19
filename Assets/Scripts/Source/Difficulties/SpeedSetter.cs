using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSetter : MonoBehaviour
{
    [SerializeField] private DifficultyLoader _difficultyLoader;
    [SerializeField] private Speed _speed;
    [SerializeField] private float _easyValue;
    [SerializeField] private float _mediumValue;
    [SerializeField] private float _hardValue;

    private void Awake()
    {
        Difficulty difficulty = _difficultyLoader.Load();
        SetGapHeight((dynamic)difficulty);
    }

    private void SetGapHeight(Easy easy)
    {
        _speed.Set(_easyValue);
    }

    private void SetGapHeight(Medium medium)
    {
        _speed.Set(_mediumValue);
    }

    private void SetGapHeight(Hard hard)
    {
        _speed.Set(_hardValue);
    }
}
