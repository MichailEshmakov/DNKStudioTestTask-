using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private VolumeSettingView _view;
    [Range(VolumeSettingUtil.MinVolume, VolumeSettingUtil.MaxVolume)] [SerializeField] private float _defaultVolume = 0;
    [SerializeField] private SoundType _soundType;
    [SerializeField] private AudioMixer _audioMixer;

    private float _volume;
    private bool _isOff;

    private string IsOffKey => _soundType.ToString() + PlayerPrefsAudioKeys.IsOffPostfix;
    private string VolumeKey => _soundType.ToString() + PlayerPrefsAudioKeys.VolumePostfix;

    private void Awake()
    {

    }

    private void Start()
    {
        LoadValues();
        _view.Init(VolumeSettingUtil.ConvertVolumeToViewValue(_volume), _isOff);
        SetMixerValue();
    }

    private void OnEnable()
    {
        _view.ValueChanged += OnViewValueChanged;
    }

    private void OnDisable()
    {
        _view.ValueChanged -= OnViewValueChanged;
    }

    private void OnDestroy()
    {
        SaveValues();
    }

    private void LoadValues()
    {
        _isOff = PlayerPrefs.HasKey(IsOffKey) && (PlayerPrefs.GetInt(IsOffKey) > 0);
        _volume = Mathf.Clamp(PlayerPrefs.GetFloat(VolumeKey, _defaultVolume), VolumeSettingUtil.MinVolume, VolumeSettingUtil.MaxVolume);
    }

    private void SaveValues()
    {
        PlayerPrefs.SetInt(IsOffKey, _isOff ? 1 : 0);
        PlayerPrefs.SetFloat(VolumeKey, _volume);
    }

    private void SetMixerValue()
    {
        if (_isOff)
            _audioMixer.SetFloat(_soundType.ToString(), VolumeSettingUtil.MinVolume);
        else
            _audioMixer.SetFloat(_soundType.ToString(), _volume);
    }

    private void OnViewValueChanged(float viewValue, bool isOff)
    {
        _isOff = isOff;
        if (_isOff == false)
            _volume = VolumeSettingUtil.ConvertViewValueToVolume(viewValue);

        SetMixerValue();
    }
}
