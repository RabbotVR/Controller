using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
   // public static int scoreValue = 0;
    public AudioSource scoreSound;
    public GameObject scoreText;
    public int theScore;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        
    }
    void OnTriggerEnter(Collider other)
	{
        scoreSound.Play();
        theScore += 50;
        scoreText.GetComponent<Text>().text = "Score: - " + theScore;
        Debug.Log("I Touched You");
	}
	// Update is called once per frame
	//void Update()
    //{
    //    score.text = "Score:" + scoreValue;

        
    //}
}
