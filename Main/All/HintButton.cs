using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintButton : MonoBehaviour
{
    public GameObject hintPanel;
    
    public void Open()
    {
        hintPanel.SetActive(true);
    }
    
    public void Close()
    {
        hintPanel.SetActive(false);
    }
}
