using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panInstrument : MonoBehaviour
{

    //Drums
    [SerializeField] private AudioSource drumSource;
    //Bass
    [SerializeField] private AudioSource bassSource;
    //Guitar1
    [SerializeField] private AudioSource g1Source;
    //Guitar2
    [SerializeField] private AudioSource g2Source;
    //Vocals
    [SerializeField] private AudioSource voxSource;
    //BackupVocals
    [SerializeField] private AudioSource backupVoxSource;

    private void panInstrumentLocal(float sliderValue, AudioSource instrument)
    {
        instrument.panStereo = sliderValue;
    }

    public void panDrums(float sliderValue)
    {
        panInstrumentLocal(sliderValue, drumSource);
    }
    public void panVox(float sliderValue)
    {
        panInstrumentLocal(sliderValue, voxSource);
    }
    public void panBackupVox(float sliderValue)
    {
        panInstrumentLocal(sliderValue, backupVoxSource);
    }
    public void panG1(float sliderValue)
    {
        panInstrumentLocal(sliderValue, g1Source);
    }
    public void panG2(float sliderValue)
    {
        panInstrumentLocal(sliderValue, g2Source);
    }
    public void panBass(float sliderValue)
    {
        panInstrumentLocal(sliderValue, bassSource);
    }

}
