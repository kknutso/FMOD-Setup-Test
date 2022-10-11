using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    FMODManager FMOD;
    string trackName;

    // Start is called before the first frame update
    void Start()
    {
        FMOD = GetComponentInChildren<FMODManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayTrack1()
    {
        trackName = "track1";
        FMOD.PlayTrack(trackName);
        Debug.Log("track 1 playing");
    }

    public void PlayTrack2()
    {
        trackName = "track2";
        FMOD.PlayTrack(trackName);
        Debug.Log("track 2 playing");
    }

    public void StopPlayback()
    {
        FMOD.StopPlayback();
        Debug.Log("Playback stopped");
    }

    public void ResumePlayback()
    {
        FMOD.ResumePlayback();
        Debug.Log("Playback resumed");
    }
}
