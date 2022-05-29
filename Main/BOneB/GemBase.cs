using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class GemBase : MonoBehaviour
{
    public List<GameObject> GemList = new List<GameObject>();
    public CameraRotation bOneBCamera;
    public SubCamera gemBaseCamera;
    public GameObject oneEDoorLeft;
    public GameObject oneEDoorRight;
    public GameObject shimenawa;
    public GameObject CameraB;
    public GameObject CameraE;
    public AudioManager audioManager;
    public Exit exit;
    public bool clear;
    
    public void ClearCheck()
    {
        if (GemList[0].activeSelf == true
            && GemList[1].activeSelf == true
            && GemList[2].activeSelf == true
            && GemList[3].activeSelf == true
            && GemList[4].activeSelf == true)
        {
            foreach (GameObject gem in GemList)
            {
                gem.GetComponent<Collider>().enabled = false;
            }
            this.GetComponent<Collider>().enabled = false;
            clear = true;
            audioManager.PlaySE(0);
            Invoke("CameraBack",1f);
            Invoke("OffCollider",2f);
            Invoke("PlaySound",2f);
            Invoke("EndCheck",3f);
        }
    }
    public void CameraBack()
    {
        gemBaseCamera.OnBackArrow();
        bOneBCamera.PhysicsRaycasterOff();
    }
    
    public void EndCheck()
    {
        int catCount = CatCounter.instance.EndCheck();
        if (catCount == 3)
        {
            Flowchart.BroadcastFungusMessage("trueEnd");
            shimenawa.SetActive(false);
            exit.exitFlag = true;
        }
        else if (catCount == 4)
        {
            Flowchart.BroadcastFungusMessage("normalEnd");
        }
        else
        {
            Flowchart.BroadcastFungusMessage("badEnd");
        }
    }
    
    public void OffCollider()
    {
        oneEDoorLeft.transform.localRotation = Quaternion.Euler(0,-30f,0);
        oneEDoorRight.transform.localRotation = Quaternion.Euler(0,30f,0);
        foreach (GameObject gem in GemList)
        {
            gem.GetComponent<Collider>().enabled = false;
        }
        this.GetComponent<Collider>().enabled = false;
        clear = true;
    }
    
    public void CameraChangeBE()
    {
        CameraB.SetActive(false);
        CameraE.SetActive(true);
    }
    public void CameraChangeEB()
    {
        CameraE.SetActive(false);
        CameraB.SetActive(true);
    }
    
    public void TitleBack()
    {
        SceneManager.LoadScene ("Start");
    }
    
    public void PlaySound()
    {
        audioManager.PlayBGM(-1);
        audioManager.PlaySE(2);
    }
}
