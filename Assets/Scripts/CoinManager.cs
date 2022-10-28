using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : Singleton<CoinManager>
{
  [SerializeField] TextMeshProUGUI coinText;
    


    public int coin;

    private void Start()
    {
        if(!PlayerPrefs.HasKey("coin"))
        {
            PlayerPrefs.SetInt("coin", 0);
            Load();
        }
        else
        {
            Load();
        }

    }

    public void gainCoin(int amount)
    {
        coin += amount;
        PlayerPrefs.SetInt("coin", coin);
        Load();
    }
    
    public void spentCoin(int amount)
    {
        coin -= amount;
        PlayerPrefs.SetInt("coin", coin);
        Load();
    }

    private void Load()
    {
        coin = PlayerPrefs.GetInt("coin");
        coinText.text = coin + " Coin"; 
    }

}
