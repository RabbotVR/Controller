﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene("controller");
    }
    public void BackToMain(){
        SceneManager.LoadScene("MainMenu"); 
    }


}
