using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubesPair : MonoBehaviour
{
    [SerializeField] private float _minGapHeight;
    [SerializeField] private float _maxGapHeight;
    [SerializeField] private Transform _aboveTube;
    [SerializeField] private Transform _underTube;

    private void OnEnable()
    {
        float halfGapHeight = Random.Range(_minGapHeight, _maxGapHeight) / 2;
        _aboveTube.localPosition = new Vector2(_aboveTube.localPosition.x, halfGapHeight);
        _underTube.localPosition = new Vector2(_underTube.localPosition.x, -halfGapHeight);
    }
}
