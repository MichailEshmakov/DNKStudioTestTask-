using UnityEngine;

public static class VolumeSettingUtil
{
    public const float MinVolume = -80;
    public const float MaxVolume = 20;

    private const int DownMultiplier = 20;
    private const int UpMultiplier = -20;
    private const float MinViewValue = 0.0001f;

    public static float ConvertVolumeToViewValue(float volume)
    {
        float multiplier = volume > 0 ? UpMultiplier : DownMultiplier;
        float viewValue = Mathf.Pow(10, volume / multiplier);
        viewValue = Mathf.Clamp(viewValue, MinViewValue, 1);
        viewValue /= 2;
        viewValue = volume > 0 ? 1 - viewValue : viewValue;

        return viewValue;
    }

    public static float ConvertViewValueToVolume(float viewValue)
    {
        float volume;
        float multiplier = DownMultiplier;

        if (viewValue >= 0.5f)
        {
            viewValue = 1 - viewValue;
            multiplier = UpMultiplier;
        }

        viewValue *= 2;
        viewValue = Mathf.Clamp(viewValue, MinViewValue, 1);
        volume = Mathf.Log10(viewValue) * multiplier;
        volume = Mathf.Clamp(volume, MinVolume, MaxVolume);

        return volume;
    }

}
