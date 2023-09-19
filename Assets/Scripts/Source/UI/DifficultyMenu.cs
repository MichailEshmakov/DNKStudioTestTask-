using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyMenu : MonoBehaviour
{
    private readonly List<Difficulty> _difficulties = new List<Difficulty>
    {   
        new Easy(),
        new Medium(),
        new Hard()
    };

    [SerializeField] private TMP_Dropdown _dropdown;
    [SerializeField] private DifficultyLoader _loader;

    private void Awake()
    {
        Difficulty difficulty = _loader.Load();
        for (int i = 0; i < _difficulties.Count; i++)
        {
            if (_difficulties[i].GetType() == difficulty.GetType())
            {
                _dropdown.value = i;
                return;
            }
        }

        Debug.LogError($"Unexpected difficulty type: {difficulty.GetType().FullName}");
    }

    private void OnEnable()
    {
        _dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDisable()
    {
        _dropdown.onValueChanged.RemoveListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int value)
    {
        _loader.Save(_difficulties[value]);
    }
}
