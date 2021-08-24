using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixController : MonoBehaviour {

    private Instrument[] instruments;

    public void Start() {
        instruments = transform.GetComponentsInChildren<Instrument>();

        TogglePauseAll();
    }

    public void TogglePauseAll() {
        foreach(Instrument instrument in instruments) {
            instrument.TogglePause();
        }
    }
    
}
