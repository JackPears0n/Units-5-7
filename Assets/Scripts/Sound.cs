using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 100f)]
    public float musicVolume;

    [Range(0f, 100f)]
    public float sFXVolume;

    //[Range(1f, 1000f)]
    //public float pitch;

    [HideInInspector]
    public AudioSource source;

}
