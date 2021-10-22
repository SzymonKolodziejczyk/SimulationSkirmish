using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStats : MonoBehaviour
{   
     public GameObject popupPanel;

    void OnMouseDown ()
    {  
        popupPanel.SetActive(true);
    }

}