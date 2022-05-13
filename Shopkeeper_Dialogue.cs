using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "shopkeeper dialogue", fileName = "new dialogue")]
public class Shopkeeper_Dialogue : ScriptableObject
{
    public Sprite shopkeeper;
    public Shopkeeper_Dialogue nextdialogue;
}
