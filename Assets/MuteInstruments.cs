using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class MuteInstruments : MonoBehaviour
{
    //Drums
    private bool drumsMuted = false;
    [SerializeField] private UnityEngine.UI.Button drumBtn;
    [SerializeField] private AudioSource drumSource;
    //Bass
    private bool bassMuted = false;
    [SerializeField] private UnityEngine.UI.Button bassBtn;
    [SerializeField] private AudioSource bassSource;
    //Guitar1
    private bool g1Muted = false;
    [SerializeField] private UnityEngine.UI.Button g1Btn;
    [SerializeField] private AudioSource g1Source;
    //Guitar2
    private bool g2Muted = false;
    [SerializeField] private UnityEngine.UI.Button g2Btn;
    [SerializeField] private AudioSource g2Source;
    //Vocals
    private bool voxMuted = false;
    [SerializeField] private UnityEngine.UI.Button voxBtn;
    [SerializeField] private AudioSource voxSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool muteInstrument(bool instMuted, UnityEngine.UI.Button btn, AudioSource track)
    {
        if (instMuted)
        {
            var colors = btn.colors;
            colors.normalColor = Color.white;
            colors.selectedColor = Color.white;
            btn.colors = colors;
            track.mute = false;
            return false;
        }
        else
        {
            instMuted = true;
            var colors = btn.colors;
            colors.normalColor = Color.red;
            colors.selectedColor = Color.red;
            btn.colors = colors;
            track.mute = true;
            return true;
        }

    }

    public void muteDrums()
    {
        drumsMuted = muteInstrument(drumsMuted, drumBtn, drumSource);
    }

    public void muteBass()
    {
        bassMuted = muteInstrument(bassMuted, bassBtn, bassSource);
    }

    public void muteG1()
    {
        g1Muted = muteInstrument(g1Muted, g1Btn, g1Source);
    }

    public void muteG2()
    {
        g2Muted = muteInstrument(g2Muted, g2Btn, g2Source);
    }

    public void muteVox()
    {
        voxMuted = muteInstrument(voxMuted, voxBtn, voxSource);
    }

}
