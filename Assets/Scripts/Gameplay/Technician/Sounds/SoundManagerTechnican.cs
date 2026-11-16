using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum SoundType
{
    //Player
    FOOTSTEP1,              //0
    FOOTSTEP2,              //1
    FOOTSTEP3,              //2
    FOOTSTEP4,              //3
    FOOTSTEP5,              //4
    INTERACT,               //5          

    //Fire
    FIRESTART,              //6
    FIREBURNING,            //7
    FIREEXTINGUISH,         //8

    //Reloading Station
    RELOADOPEN,             //9
    AMMO1,                  //10

    //Scanner Station
    SCANNEROPEN,            //11
    TYPING,                 //12

    //General Minigame
    SUCCESS,                //13
    FAIL,                   //14

    //Settings
    SETTINGOPEN,            //15
    SETTINGCLOSE            //16
}

[RequireComponent(typeof(AudioSource))]
public class SoundManagerTechnican : MonoBehaviour
{
    [SerializeField] private AudioClip[] soundList;
    private AudioSource audioSource;
    private static SoundManagerTechnican Instance; //singleton

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        audioSource = GetComponent<AudioSource>();

        for (int i = 0; i < soundList.Length; i++)
        {
            if (soundList[i] == null)
                Debug.LogError($"soundList[{i}] is null! Enum: {(SoundType)i}", this);
        }
    }


    public static void PlaySound(
    SoundType sound,
    float volume = 1f,
    float pitchMin = 1f,
    float pitchMax = 1f)
    {
        if (Instance == null)
        {
            Debug.LogWarning(
                $"Cannot play {sound}: no active SoundManagerTechnican.");
            return;
        }

        if (Instance.audioSource == null)
        {
            Debug.LogError("SoundManagerTechnican has no AudioSource.", Instance);
            return;
        }

        int index = (int)sound;

        if (Instance.soundList == null ||
            index < 0 ||
            index >= Instance.soundList.Length ||
            Instance.soundList[index] == null)
        {
            Debug.LogWarning($"Missing audio clip for {sound}.", Instance);
            return;
        }

        Instance.audioSource.pitch = Random.Range(pitchMin, pitchMax);
        Instance.audioSource.PlayOneShot(Instance.soundList[index], volume);
        Instance.audioSource.pitch = 1f;
    }

    public static void PlaySoundVariation(SoundType sound, float volume = 1f)
    {
        int index = (int)sound;
        AudioClip clip = Instance.soundList[index];

        int[] pentatonicSemitones = new[] { 0, 2, 4, 7, 9 };
        int semitone = pentatonicSemitones[Random.Range(0, pentatonicSemitones.Length)];

        float pitch = Mathf.Pow(1.059463f, semitone); // Semitone-based pitch

        Instance.audioSource.pitch = pitch;
        Instance.audioSource.clip = clip;
        Instance.audioSource.volume = volume;
        Instance.audioSource.Play();
        //Debugging
        //Debug.Log($"Playing {sound} at pitch ({pitch}) with semitone offset: {semitone}");
        
    }
}
