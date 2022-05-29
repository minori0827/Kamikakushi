using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCamera : CameraChanger
{
    public GameObject mainCamera;
    public GameObject subCamera;
    public GameObject subObject;
    public GameObject backArrow;
    public GameObject LRArrow;
    public GameObject menu;
    
    public virtual void ReturnArrow()
    {
        
    }
    
    public void OnBackArrow()
    {
        CameraChange(subCamera,mainCamera);
        subObject.GetComponent<Collider>().enabled = true;
        ReturnArrow();
        backArrow.SetActive(false);
        menu.SetActive(true);
        LRArrow.SetActive(true);
    }
    
    public void OnSubObject()
    {
        LRArrow.SetActive(false);
        CameraChange(mainCamera,subCamera);
        subObject.GetComponent<Collider>().enabled = false;
        backArrow.SetActive(true);
        menu.SetActive(false);
    }
}
