using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    bool isPaused = true;

    public void unPauseGame()
    {
        if (isPaused) {
            Time.timeScale = 1;
            isPaused = true;
        }
    }
}
