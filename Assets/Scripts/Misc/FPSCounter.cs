using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FPSCounter : MonoBehaviour
{
    private int framecount;
    private float pollingTime = 0.1f;
    private float time;
    public TextMeshProUGUI FpsText;
    private bool FrameRateLocked = false;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        framecount++;
        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(framecount / time);
            FpsText.text = frameRate.ToString() + " FPS";
            time -= pollingTime;
            framecount = 0;
            if (FrameRateLocked == true)
            {
                Application.targetFrameRate = 30;
            }
            else if (FrameRateLocked == false)
            {
                Application.targetFrameRate = 300;
            }
        }

    }
    public void FPSLockto30()
    {
        FrameRateLocked = true;
    }
    public void FPSUnlock()
    {
        FrameRateLocked = false;
    }
}
