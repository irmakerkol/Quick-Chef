using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationBarManager : MonoBehaviour
{
    
    SoundManager sm;

    void Start()
    {
        sm = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }

    public void onShopButtonClick()
    {
        sm.playAudio();
        SceneManager.LoadSceneAsync("Shop Scene");
    }
    
    public void onHomeButtonClick()
    {
        sm.playAudio();
        SceneManager.LoadSceneAsync("Home Scene");
    }
    
    public void onSettingsButtonClick()
    {
        sm.playAudio();
        SceneManager.LoadSceneAsync("Settings Scene");
    }

    public void onPlayButtonClick()
    {
        sm.playAudio();
        SceneManager.LoadSceneAsync("Game Scene");
    }


}
