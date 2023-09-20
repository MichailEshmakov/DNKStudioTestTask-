using UnityEngine;

public class TubesPair : MonoBehaviour
{
    [SerializeField] private Transform _aboveTube;
    [SerializeField] private Transform _underTube;
    [SerializeField] private BoxCollider2D _gapTrigger;

    private TubesGapHeight _height;

    private void Awake()
    {
        _height = FindObjectOfType<TubesGapHeight>(); // TODO: init
    }

    private void OnEnable()
    {
        float gapHeight = Random.Range(_height.Min, _height.Max);
        float halfGapHeight = gapHeight / 2;
        _aboveTube.localPosition = new Vector2(_aboveTube.localPosition.x, halfGapHeight);
        _underTube.localPosition = new Vector2(_underTube.localPosition.x, -halfGapHeight);
        _gapTrigger.size = new Vector2(_gapTrigger.size.x, gapHeight);
    }
}
