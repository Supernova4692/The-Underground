using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        
        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    // Update is called once per frame
    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
    }

    void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
    }
}
