using UnityEngine;

public class TubesGapHeight : MonoBehaviour
{
    private float _min;
    private float _max;

    public float Min => _min;
    public float Max => _max;

    public void SetMin(float min) => _min = min;
    public void SetMax(float max) => _max = max;
}
