using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;


public class FMODManager : MonoBehaviour
{
    EventInstance instance;
    FMOD.Studio.STOP_MODE mode;
    string lastTrackPlayed = "";

    internal void PlayTrack(string trackName)
    {
        if(lastTrackPlayed == trackName) { return; }
        instance.stop(mode);
        instance = RuntimeManager.CreateInstance("event:/" + trackName);
        instance.start();
        lastTrackPlayed = trackName;
    }

    internal void ResumePlayback()
    {
        instance.setPaused(false);
    }

    internal void StopPlayback()
    {
        instance.setPaused(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
