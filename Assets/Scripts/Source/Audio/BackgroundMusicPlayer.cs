using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BackgroundMusicPlayer : MonoBehaviour
{
    private static BackgroundMusicPlayer s_instance;

    public static BackgroundMusicPlayer Instance => s_instance;

    private void Awake()
    {
        if (Instance == null)
            s_instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource.enabled)
            audioSource.Play();
    }

    public void Disable()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

    public void Enable()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
}
