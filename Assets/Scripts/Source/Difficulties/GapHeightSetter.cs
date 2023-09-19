using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GapHeightSetter : MonoBehaviour
{
    [SerializeField] private DifficultyLoader _difficultyLoader;
    [SerializeField] private TubesGapHeight _tubesGapHeight;
    [SerializeField] private float _easyMin;
    [SerializeField] private float _easyMax;
    [SerializeField] private float _mediumMin;
    [SerializeField] private float _mediumMax;
    [SerializeField] private float _hardMin;
    [SerializeField] private float _hardMax;

    private void Awake()
    {
        Difficulty difficulty = _difficultyLoader.Load();
        SetGapHeight((dynamic)difficulty);
    }

    private void SetGapHeight(Easy easy)
    {
        _tubesGapHeight.SetMin(_easyMin);
        _tubesGapHeight.SetMax(_easyMax);
    }

    private void SetGapHeight(Medium medium)
    {
        _tubesGapHeight.SetMin(_mediumMin);
        _tubesGapHeight.SetMax(_mediumMax);
    }

    private void SetGapHeight(Hard hard)
    {
        _tubesGapHeight.SetMin(_hardMin);
        _tubesGapHeight.SetMax(_hardMax);
    }
}
