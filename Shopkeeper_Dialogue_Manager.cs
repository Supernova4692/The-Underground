using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopkeeper_Dialogue_Manager : MonoBehaviour
{
    [SerializeField]
    private Image uiimage;
    [SerializeField]
    private Shopkeeper_Dialogue currentdialogue;
    // Start is called before the first frame update
    void Start()
    {
        UpdateDialogue(currentdialogue);
    }

    public void dialogueclick()
    {
        UpdateDialogue(currentdialogue.nextdialogue);
    }
    void UpdateDialogue(Shopkeeper_Dialogue newdialogue)
    {
        if (newdialogue != null)
        {
            if (newdialogue.shopkeeper != null)
            {
                uiimage.sprite = newdialogue.shopkeeper;
            }
            currentdialogue = newdialogue;
        }
        else
        {

        }
    }
}
