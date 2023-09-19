using UnityEngine;

public class Speed : MonoBehaviour
{
    private float _value;

    public float Value => _value;

    public void Set(float value) // TODO: segregate interfaces
    {
        _value = value;
    }
}
