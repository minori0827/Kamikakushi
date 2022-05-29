using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece16 : MonoBehaviour
{
    public SlidePuzzle16 slidePuzzle16;
    
    public void PeiceMove()
    {
        bool hitUp = Physics.Raycast(transform.position,Vector3.up,0.3f);
        bool hitDown = Physics.Raycast(transform.position,Vector3.down,0.3f);
        bool hitRight = Physics.Raycast(transform.position,Vector3.left,0.3f);
        bool hitLeft = Physics.Raycast(transform.position,Vector3.right,0.3f);
        if (!hitUp)
        {
            transform.localPosition += new Vector3(2.25f,0,0);
        }
        else if (!hitDown)
        {
            transform.localPosition += new Vector3(-2.25f,0,0);
        }
        else if (!hitRight)
        {
            transform.localPosition += new Vector3(0,0,-2.25f);
        }
        else if (!hitLeft)
        {
            transform.localPosition += new Vector3(0,0,2.25f);
        }
        slidePuzzle16.ClearCheck();
    }
}
