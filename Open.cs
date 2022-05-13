using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
public void OpenUrl (string URLname)
    {
        Application.OpenURL(URLname);
    }
}
