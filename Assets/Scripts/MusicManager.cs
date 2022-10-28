using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Image musicOnIcon;
    [SerializeField] Image musicOffIcon;
    private bool muted = false;

    public AudioSource audio; 



    void Start()
    {
       
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        if(muted)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();

        }
        

        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            musicOnIcon.enabled = true;
            musicOffIcon.enabled = false;
        } 
        else
        {
            musicOnIcon.enabled = false;
            musicOffIcon.enabled = true;
        }
    }

    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();

        } 
        else 
        {
            muted = false;
            GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayMusic();

        }

        Save();
        UpdateButtonIcon();
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

}
