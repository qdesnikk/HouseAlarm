using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ControlAudio : MonoBehaviour
{
    private AudioSource _audio;

    void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void StartAlarmSound()
    {
        _audio.Play();
        _audio.DOFade(1f, 3);
    }

    public void StopAlarmSound()
    {
        _audio.DOFade(0f, 3);

        if (_audio.volume == 0)
            _audio.Stop();
    }
}
