using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text score;
    public GameObject panel;
    public void win() 
    {
        panel.SetActive(true);   
        
    }
    public void lose()
    {
        Invoke("restart", 2f);
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
