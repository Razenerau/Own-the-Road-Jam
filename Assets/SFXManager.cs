using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;
    public GameObject PreFab;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void PlaySFX(AudioClip clip, Transform t, float volume)
    {
        AudioSource source = Instantiate(PreFab, t.position, Quaternion.identity).GetComponent<AudioSource>();
        source.clip = clip;
        source.volume = volume;
        float length = source.clip.length;
        source.Play();

        Destroy(source.gameObject, length);
    }

    public void PlaySFX(List<AudioClip> clipList, Transform t, float volume)
    {
        int random = Random.Range(0, clipList.Count - 1);
        AudioSource source = Instantiate(PreFab, t.position, Quaternion.identity).GetComponent<AudioSource>();
        source.clip = clipList[random];
        source.volume = volume;
        float length = source.clip.length;
        source.Play();

        Destroy(source.gameObject, length);
    }
}
