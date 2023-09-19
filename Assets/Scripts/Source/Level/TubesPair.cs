using UnityEngine;

public class TubesPair : MonoBehaviour
{
    [SerializeField] private Transform _aboveTube;
    [SerializeField] private Transform _underTube;

    private TubesGapHeight _height;

    private void Awake()
    {
        _height = FindObjectOfType<TubesGapHeight>(); // TODO: init
    }

    private void OnEnable()
    {
        float halfGapHeight = Random.Range(_height.Min, _height.Max) / 2;
        _aboveTube.localPosition = new Vector2(_aboveTube.localPosition.x, halfGapHeight);
        _underTube.localPosition = new Vector2(_underTube.localPosition.x, -halfGapHeight);
    }
}
