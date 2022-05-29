using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOneDCamera : CameraRotation
{
    enum BODR
    {
        BODR0 = 0,
        BODR1 = 1,
    }

    BODR BODCR = BODR.BODR0;

    public void Start()
    {
        HideArrows();
        rightArrow.SetActive(true);
    }
    
    public void OnRightArrow()
    {
        BODCR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        BODCR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (BODCR == BODR.BODR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 180 , 0);
            rightArrow.SetActive(true);
        }
        else if (BODCR == BODR.BODR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 270 , 0);
            leftArrow.SetActive(true);
        }
    }
}

