using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBook : MonoBehaviour
{
    public GameObject noteBookCanvas;
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;
    public List<GameObject> textList = new List<GameObject>();
    public int currentText = 0;
    
    public void Open()
    {
        noteBookCanvas.SetActive(true);
    }
    public void Close()
    {
        noteBookCanvas.SetActive(false);
    }
    public void OnRightArrow()
    {
        textList[currentText].SetActive(false);
        textList[currentText+1].SetActive(true);
        currentText = currentText + 1;
        if (currentText + 1 == textList.Count)
        {
            rightArrow.SetActive(false);
        }
        leftArrow.SetActive(true);
    }
    public void OnLeftArrow()
    {
        textList[currentText].SetActive(false);
        textList[currentText-1].SetActive(true);
        currentText = currentText - 1;
        if (currentText == 0)
        {
            leftArrow.SetActive(false);
        }
        rightArrow.SetActive(true);
    }
}
