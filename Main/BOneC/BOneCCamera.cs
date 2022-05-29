using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOneCCamera : CameraRotation
{
    enum BOCR
    {
        BOCR0 = 0,
        BOCR1 = 1,
    }

    BOCR BOCCR = BOCR.BOCR1;

    public void Start()
    {
        HideArrows();
        leftArrow.SetActive(true);
    }
    
    public void OnRightArrow()
    {
        BOCCR ++;
        ChangeRotation();
    }
    
    public void OnLeftArrow()
    {
        BOCCR --;
        ChangeRotation();
    }
    
    public void ChangeRotation()
    {
        HideArrows();
        if (BOCCR == BOCR.BOCR0)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 90 , 0);
            rightArrow.SetActive(true);
        }
        else if (BOCCR == BOCR.BOCR1)
        {
            Camera.transform.localRotation = Quaternion.Euler(0 , 180 , 0);
            leftArrow.SetActive(true);
        }
    }
}
