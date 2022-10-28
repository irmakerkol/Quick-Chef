using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool soundMuted = false;
    public AudioSource audio;

    public void playAudio()
    {
        if (soundMuted == false)
        {
            audio.Play();
        }
    }
    void Start()
    {
        print("game started with soundMuted = " +  soundMuted);
        if(!PlayerPrefs.HasKey("soundMuted"))
        {
            PlayerPrefs.SetInt("soundMuted", 0);
            Load();
        }
        else
        {
            Load();
        }

        if(SceneManager.GetActiveScene().name == "Settings Scene")
        {
            UpdateButtonIcon();
        }
    }

    private void UpdateButtonIcon()
    {
        if(soundMuted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        } 
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    public void OnButtonPress()
    {
        if(soundMuted == false)
        {
            soundMuted = true;
        } 
        else 
        {
            soundMuted = false;
        }

        Save();
        UpdateButtonIcon();
    }

    private void Load()
    {
        soundMuted = PlayerPrefs.GetInt("soundMuted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("soundMuted", soundMuted ? 1 : 0);
    }

}
