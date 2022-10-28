using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : Singleton<LevelManager>
{
  [SerializeField] TextMeshProUGUI levelText;
    


    public int level;

    private void Start()
    {
        if(!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 1);
            Load();
        }
        else
        {
            Load();
        }

    }

    public void levelUp()
    {
        level += 1;
        PlayerPrefs.SetInt("level", level);
        Load();

        if(level % 3 == 0)
        {
            CoinManager.instance.gainCoin(15);
        }
    }

      public void levelDown()
    {
        level -= 1;
        PlayerPrefs.SetInt("level", level);
        Load();

        if(level % 3 == 0)
        {
            CoinManager.instance.spentCoin(15);
        }
    }

    private void Load()
    {
        level = PlayerPrefs.GetInt("level");
        levelText.text = "Level " + level; 
    }

}
