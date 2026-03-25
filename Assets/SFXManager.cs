using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;
    public GameObject PreFab;
    public AudioSource MainAudioSource;

    [Header("SFX/Music")]
    public AudioClip ClickClip;
    public AudioClip GoodEnding;
    public AudioClip BadEnding;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void PlaySFX(AudioClip clip, Transform t, float volume)
    {
        if (CanvasController.IsGameOver) return;
        AudioSource source = Instantiate(PreFab, t.position, Quaternion.identity).GetComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume;
        float length = source.clip.length;
        source.Play();

        Destroy(source.gameObject, length);
    }

    public void PlaySFX(List<AudioClip> clipList, Transform t, float volume)
    {
        if (CanvasController.IsGameOver) return;
        int random = Random.Range(0, clipList.Count - 1);
        AudioSource source = Instantiate(PreFab, t.position, Quaternion.identity).GetComponent<AudioSource>();
        source.clip = clipList[random];
        source.volume = volume;
        float length = source.clip.length;
        source.Play();

        Destroy(source.gameObject, length);
    }

    public void PlayClick()
    {
        PlaySFX(ClickClip, transform, 1f);
    }

    public void PlayGoodEndMusic()
    {
        MainAudioSource.clip = GoodEnding;
        MainAudioSource.Play();
    }

    public void PlayBadEndMusic()
    {
        MainAudioSource.clip = BadEnding;
        MainAudioSource.Play();
    }
}
