using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Customization : MonoBehaviour
{
    Sprite[] spriteSheet;
    int currentHairID, currentColorID;
    Image CharacterImage;
    void Start()
    {
        CharacterImage = GameObject.Find("CharacterImage").GetComponent<Image>();
        currentHairID = 0;
        currentColorID = 0;
        spriteSheet = Resources.LoadAll<Sprite>("spritexb");
           

    }

    // Update is called once per frame
    public void ChangeHair()
    {
        if (currentHairID < 2)
        {
            currentHairID++;
        }else if (currentHairID == 2)
        {
            currentHairID = 0;

        }

        foreach ( Sprite S in spriteSheet)
        {
            if(S.name.Equals("spritexb_" + currentColorID + currentHairID))
            {
                CharacterImage.sprite = S;
            }
        }
    }


    public void ChangeColor()
    {
        if (currentColorID < 2)
        {
            currentColorID++;
        }
        else if (currentColorID == 2)
        {
            currentColorID = 0;

        }

        foreach (Sprite S in spriteSheet)
        {
            if (S.name.Equals("spritexb_" + currentColorID + currentHairID))
            {
                CharacterImage.sprite = S;
            }
        }
    }
}
