using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;

    [SerializeField] private AudioSource gameAudioSource;
    [SerializeField] private AudioClip[] gameAudioClip;

    private void Awake() {
        soundManager = this;
    }

    public void playSound(int audioClip) {
        if(audioClip>=0 && audioClip<gameAudioClip.Length) {
            gameAudioSource.PlayOneShot(gameAudioClip[audioClip]);
        }
    }
}
