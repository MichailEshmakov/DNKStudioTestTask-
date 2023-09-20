using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyLoader : MonoBehaviour
{
    private const string Key = "Difficulty";
    private readonly Type _defaultType = typeof(Medium);

    private Difficulty _difficulty;

    public Difficulty Load()
    {
        if (_difficulty == null)
        {
            string name = PlayerPrefs.GetString(Key);
            if (string.IsNullOrEmpty(name))
                name = GetDefaultName();

            SetDifficulty(name);
        }

        return _difficulty;
    }

    public void Save(Difficulty difficulty)
    {
        _difficulty = difficulty;
        PlayerPrefs.SetString(Key, difficulty.GetType().FullName);
    }

    private string GetDefaultName()
    {
        return _defaultType.FullName;
    }

    private void SetDifficulty(string name)
    {
        Type loadedType = typeof(Difficulty).Assembly.GetType(name);
        Type difficultyType;
        if (typeof(Difficulty).IsAssignableFrom(loadedType))
        {
            difficultyType = loadedType;
        }
        else
        {
            Debug.LogError($"Unexpected type: {loadedType.FullName}");
            difficultyType = _defaultType;
        }

        _difficulty = (Difficulty)Activator.CreateInstance(difficultyType);
    }
}
