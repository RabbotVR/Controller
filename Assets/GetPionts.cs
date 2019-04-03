using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPionts : MonoBehaviour
{
    public AudioSource scoreSound;
    void OnTriggerEnter(Collider other)
    {
        scoreSound.Play();
        ScoreScript.theScore += 10;
        Destroy(gameObject);
     
    }
}
