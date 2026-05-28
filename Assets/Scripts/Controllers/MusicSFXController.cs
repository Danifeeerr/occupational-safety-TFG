using UnityEngine;

public class MusicSFXController : MonoBehaviour
{
    public AudioClip music;
    void Start()
    {
        AudioController.Instance.PlayMusic(music);
    }

    public void PlayMusic(AudioClip musicClip)
    {
        AudioController.Instance.PlayMusic(musicClip);
    }

    public void PlaySFX(AudioClip SFXClip)
    {
        AudioController.Instance.PlaySFX(SFXClip);
    }
}
