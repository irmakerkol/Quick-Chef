using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class IngridientAndPanCollision : MonoBehaviour
{

    private bool isColliding = false;

    private float oldZ;
    private string[] correctIngridients;

    private string ingridient1_tag;
    private string ingridient2_tag;
    private string ingridient3_tag;

    private bool isTweening = false;

    private Vector3 oldPosition = new Vector3(0f,0f,0f);

    void Start()
    {
        oldPosition = this.gameObject.transform.position;

    }
    

   void Update()
   {
        if (isColliding)
        {
            oldZ = this.gameObject.transform.position.z;

            if(LevelManager.instance.level == 1)
            {
                if(Level1.instance.currentReciepe == 1)
                {
                    ingridient1_tag = Level1.instance.reciepe1_ingridient1;
                    ingridient2_tag = Level1.instance.reciepe1_ingridient2;
                    ingridient3_tag = Level1.instance.reciepe1_ingridient3;
                    
                    Vector3 otherPosition = new Vector3 (43f/300, -39f, oldZ);
                    Vector3 animationPosition = new Vector3 (43f/300, 0f , oldZ);

                    this.gameObject.transform.position = otherPosition;
                    
                    if (this.gameObject.tag != ingridient1_tag & 
                        this.gameObject.tag != ingridient2_tag &
                        this.gameObject.tag != ingridient3_tag)
                    {
                        //animasyon gelecek
                        if (!isTweening)
                        {
                            Tween myTween = transform.DOMove(oldPosition, 2);
                            myTween.SetEase(Ease.OutQuint);
                            myTween.SetLoops(1);
                            isTweening = true;
                            Debug.Log("girdi");
                            myTween.OnComplete(setTweeningFalse);

                        }
        
                    }
                }
            }
        }

   }

    void setTweeningFalse()
    {
        isTweening = false;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Pan")
        {
            isColliding = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Pan")
        {
            isColliding = false;
        }
    }

 
} 
