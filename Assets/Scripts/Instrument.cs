using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Instrument : MonoBehaviour{

    [SerializeField] private AudioClip stem;
    [SerializeField] private AudioMixerGroup mixerMaster;
    [SerializeField] private Transform canvas;

    private AudioSource track;
    private bool isMuted = false;

    public void Awake() {
        track = gameObject.GetComponentInChildren<AudioSource>();
        track.clip = stem;
        track.outputAudioMixerGroup = mixerMaster;

        canvas.Find("InstText").GetComponent<Text>().text = transform.name;

        Button muteButton = canvas.Find("Mute_btn").GetComponent<Button>();
        muteButton.onClick.AddListener(() => ToggleMute(muteButton));
    }

    public void ToggleMute(Button muteButton) {
        isMuted = !isMuted;
        track.mute = isMuted;

        var colors = muteButton.colors;
        colors.normalColor = isMuted ? Color.red : Color.white;
        colors.selectedColor = isMuted ? Color.red : Color.white;
        muteButton.colors = colors;
    }

    public void TogglePause() {
        track.Play();
    }

}
