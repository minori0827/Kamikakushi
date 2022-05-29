using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOnOff : MonoBehaviour
{
    public GameObject Window;
    
    public void WindowOn()
    {
        Window.SetActive(true);
    }
    public void WindowOff()
    {
        Window.SetActive(false);
    }
}
