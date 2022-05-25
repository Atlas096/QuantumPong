using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource beepPlayer;
    public AudioSource beepWall;
    public AudioSource beepScore;

    public void playerBeep()
    {
        beepPlayer.Play();
    }

    public void wallBeep()
    {
        beepWall.Play();
    }

    public void scoreBeep()
    {
        beepScore.Play();
    }
}
