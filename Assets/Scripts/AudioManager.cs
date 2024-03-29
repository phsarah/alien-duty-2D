﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSFX audioSFX;
    void Awake () {
        if(instance == null) {
           instance = this;
        }

    }    

    //public void PlaySoundlifePickup(GameObject obj) {
   //     AudioSource.PlayClipAtPoint(audioSFX.lifePickup, obj.transform.position);
   // }

  //  public void PlaySoundlifeLost(GameObject obj) {
   //     AudioSource.PlayClipAtPoint(audioSFX.lifeLost, obj.transform.position);
   // }
    public void PlaySoundStarPickup(GameObject obj) {
        AudioSource.PlayClipAtPoint(audioSFX.starPickup, obj.transform.position);
    }

    //public void PlaySoundFail(GameObject obj) {
    //    AudioSource.PlayClipAtPoint(audioSFX.fail, obj.transform.position);
     // }
  //  public void PlaySoundLevelComplete(GameObject obj) {
    //    AudioSource.PlayClipAtPoint(audioSFX.levelComplete, obj.transform.position);
   // }
}
