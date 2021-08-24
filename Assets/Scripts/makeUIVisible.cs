using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeUIVisible : MonoBehaviour
{
    bool UIVisible = true;
    public GameObject handUI;
    public GameObject[] canvases;
    private int oldCanvasNo = 0;

    private void Start()
    {
        handUI.SetActive(true);

        foreach(GameObject canvas in canvases)
        {
            canvas.SetActive(false);

        }
        canvases[0].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetUp(OVRInput.Button.Four))
        {
            if(UIVisible)
            {
                handUI.SetActive(false);
                UIVisible = false;

            } else
            {
                handUI.SetActive(true);
                UIVisible = true;
            }

        }
        if (OVRInput.GetUp(OVRInput.Button.Three))
        {
            changeScreen(0);
        }
    }

    public void changeScreen(int canvasNo)
    {
        canvases[oldCanvasNo].SetActive(false);
        canvases[canvasNo].SetActive(true);
        oldCanvasNo = canvasNo;

    }
}
