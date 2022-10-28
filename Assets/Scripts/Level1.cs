using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : Singleton<Level1>
{
    
    public Image reciepe1_ingridient1_image;
    public Image reciepe1_ingridient2_image;
    public Image reciepe1_ingridient3_image;

    public string reciepe1_ingridient1 = "banana";
    public string reciepe1_ingridient2 = "grape";
    public string reciepe1_ingridient3 = "watermelon";

    public string reciepe1_food = "Fruit Salad";
    public int currentReciepe = 1;

}
