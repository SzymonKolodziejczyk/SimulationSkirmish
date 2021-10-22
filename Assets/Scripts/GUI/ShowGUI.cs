using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowGUI : MonoBehaviour
{   
     public GameObject popupPanel;

    void OnMouseDown ()
    {  
        popupPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void BackToMainMenu ()
    {  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}