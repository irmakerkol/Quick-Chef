 using UnityEngine;
 
 public class Music : MonoBehaviour
 {
    private AudioSource audioSource;
    private static Music music;


    private void Awake()
    {
        if(music == null)
        {
            music = this;
            DontDestroyOnLoad(transform.gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else {
            Destroy(gameObject);
        }
       
    }
 
    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
         audioSource.Play();
    }
 
    public void StopMusic()
    {
        audioSource.Stop();
    }
 }