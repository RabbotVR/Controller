using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitThings : MonoBehaviour
{
    public AudioSource scoreSound;
    void OnTriggerEnter(Collider other)
    {
        scoreSound.Play();
        ScoreScript.theScore += 50;
        //Debug.Log("I Touched You");
    }
}
