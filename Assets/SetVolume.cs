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
    public AudioMixer backupVoxMixer;

    private bool voxChipmunk = false;
    [SerializeField] private UnityEngine.UI.Button voxChipmunkBtn;
    private bool backupVoxChipmunk = false;
    [SerializeField] private UnityEngine.UI.Button backupVoxChipmunkBtn;

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
    public void setBackupVoxVolume(float sliderValue)
    {
        SetLevel(sliderValue, backupVoxMixer, "BackupVoxVolume");
    }
    public void setG1Volume(float sliderValue)
    {
        SetLevel(sliderValue, g1Mixer, "G1Volume");
    }
    public void setG2Volume(float sliderValue)
    {
        SetLevel(sliderValue, g2Mixer, "G2Volume");
    }

    public void chipmunkVox()
    {
        if (voxChipmunk) {
            voxMixer.SetFloat("VoxPitch", 1.0f);
            voxChipmunk = false;
            var colors = voxChipmunkBtn.colors;
            colors.normalColor = Color.white;
            colors.selectedColor = Color.white;
            voxChipmunkBtn.colors = colors;
        } else
        {
            voxMixer.SetFloat("VoxPitch", 2.0f);
            voxChipmunk = true;
            var colors = voxChipmunkBtn.colors;
            colors.normalColor = Color.green;
            colors.selectedColor = Color.green;
            voxChipmunkBtn.colors = colors;
        }
    }
    public void backupChipmunkVox()
    {
        if (backupVoxChipmunk)
        {
            backupVoxMixer.SetFloat("VoxPitch", 1.0f);
            backupVoxChipmunk = false;
            var colors = backupVoxChipmunkBtn.colors;
            colors.normalColor = Color.white;
            colors.selectedColor = Color.white;
            backupVoxChipmunkBtn.colors = colors;
        }
        else
        {
            backupVoxMixer.SetFloat("VoxPitch", 2.0f);
            backupVoxChipmunk = true;
            var colors = backupVoxChipmunkBtn.colors;
            colors.normalColor = Color.green;
            colors.selectedColor = Color.green;
            backupVoxChipmunkBtn.colors = colors;
        }
    }
}
