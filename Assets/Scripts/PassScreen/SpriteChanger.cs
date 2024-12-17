using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteChanger : MonoBehaviour
{
   public Image image;
   private Image originalimage;
   public Sprite ItemSprite;
    void Start()
    {
      originalimage = image.GetComponent<Image>();  
    }

   
    public void ChangeImageTo()
    {
        originalimage.sprite = ItemSprite;
    }
}
