using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using TMPro;

public class GameManager : Singleton<GameManager>
{

    [SerializeField] Image ingridient1_image;
    [SerializeField] Image ingridient2_image;
    [SerializeField] Image ingridient3_image;
    [SerializeField] TextMeshProUGUI nameOfFoodText;

    void Start()
    {
        if (LevelManager.instance.level == 1)
        {
            if(Level1.instance.currentReciepe == 1)
            {
                ingridient1_image.sprite = Level1.instance.reciepe1_ingridient1_image.sprite;
                ingridient2_image.sprite = Level1.instance.reciepe1_ingridient2_image.sprite;
                ingridient3_image.sprite = Level1.instance.reciepe1_ingridient3_image.sprite;
                nameOfFoodText.text = Level1.instance.reciepe1_food;
            }
        }
    }

}
