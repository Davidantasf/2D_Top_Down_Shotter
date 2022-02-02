using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{
    public static AudioClip shotSound, shotgunSound, hurtSound, sandSound;
    static AudioSource audioSrc;

    void Start()
    {
        shotSound = Resources.Load<AudioClip> ("tiro");
        shotgunSound = Resources.Load<AudioClip> ("shotgun");
        hurtSound = Resources.Load<AudioClip> ("hurt");
        sandSound = Resources.Load<AudioClip> ("Sand");
        

        audioSrc = GetComponent<AudioSource> ();
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
        case "tiro":
        audioSrc.PlayOneShot (shotSound);
        break;
        case "shotgun":
        audioSrc.PlayOneShot (shotgunSound);
        break;
        case "hurt":
        audioSrc.PlayOneShot (hurtSound);
        break;
        case "Sand":
        audioSrc.PlayOneShot (sandSound);
        break;
        }
    }








}