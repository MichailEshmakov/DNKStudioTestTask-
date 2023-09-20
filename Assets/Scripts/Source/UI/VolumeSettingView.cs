using System;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettingView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Toggle _switchOffToggle;

    private float _previousValue;

    public float Value => _slider.value;

    public event Action<float, bool> ValueChanged;

    private void OnDestroy()
    {
        RemoveListeners();
    }

    public void Init(float value, bool isOff)
    {
        RemoveListeners();

        _previousValue = value;
        _slider.value = value;

        _switchOffToggle.onValueChanged.AddListener(OnToggleValueChanged);
        _slider.onValueChanged.AddListener(OnSliderValueChanged);

        _switchOffToggle.isOn = isOff;
    }

    private void OnToggleValueChanged(bool isOff)
    {
        _slider.interactable = isOff == false;
        if (isOff)
        {
            _previousValue = _slider.value;
            _slider.value = _slider.minValue;
        }
        else
        {
            _slider.value = _previousValue;
        }
    }

    private void OnSliderValueChanged(float value)
    {
        ValueChanged?.Invoke(value, _switchOffToggle.isOn);
    }

    private void RemoveListeners()
    {
        _switchOffToggle.onValueChanged.RemoveListener(OnToggleValueChanged);
        _slider.onValueChanged.RemoveListener(OnSliderValueChanged);
    }
}
