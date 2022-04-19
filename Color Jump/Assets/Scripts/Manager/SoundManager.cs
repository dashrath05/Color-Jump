using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip ballBlastClip;
    public AudioClip bounceBallClip;
    public AudioClip ballHitClip;
    public AudioClip colorChangeClip;


    public static SoundManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void BallBlast()
    {
        audioSource.PlayOneShot(ballBlastClip);
    }
    public void BounceBall()
    {
        audioSource.PlayOneShot(bounceBallClip);
    }
    public void BollHit()
    {
        audioSource.PlayOneShot(ballHitClip);
    }
    public void ColorChange()
    {
        audioSource.PlayOneShot(colorChangeClip);
    }
}
