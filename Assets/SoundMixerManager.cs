using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMixerManager : MonoBehaviour
{
    public AudioMixer AudioMixer;

    public void SetMaster(float v)
    {
        AudioMixer.SetFloat("Master", v);
    }

    public void SetMusic(float v)
    {
        AudioMixer.SetFloat("Music", v);
    }

    public void SetSFX(float v)
    {
        AudioMixer.SetFloat("SFX", v);
    }
}
