using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{
    public GameObject BackCheck;
    
    public void BackCheckOn()
    {
        BackCheck.SetActive(true);
    }
    public void BackCheckOff()
    {
        BackCheck.SetActive(false);
    }
    public void TitleBack()
    {
        SceneManager.LoadScene ("Start");
    }
}
