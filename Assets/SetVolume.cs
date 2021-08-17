using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer drumMixer;
    public AudioMixer g1Mixer;
    public AudioMixer g2Mixer;
    public AudioMixer bassMixer;
    public AudioMixer voxMixer;

    void SetLevel (float sliderValue, AudioMixer mixer, string mixerName)
    {
        mixer.SetFloat(mixerName, Mathf.Log10(sliderValue)*20);
    }

    public void setDrumVolume(float sliderValue)
    {
        SetLevel(sliderValue, drumMixer, "DrumVolume");
    }
    public void setBassVolume(float sliderValue)
    {
        SetLevel(sliderValue, bassMixer, "BassVolume");
    }
    public void setVoxVolume(float sliderValue)
    {
        SetLevel(sliderValue, voxMixer, "VoxVolume");
    }
    public void setG1Volume(float sliderValue)
    {
        SetLevel(sliderValue, g1Mixer, "G1Volume");
    }
    public void setG2Volume(float sliderValue)
    {
        SetLevel(sliderValue, g2Mixer, "G2Volume");
    }
}
