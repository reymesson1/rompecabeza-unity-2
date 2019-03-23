using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movpiesa : MonoBehaviour
{


    private void OnMouseDown()
    {
        if (!Rotartion.youwin)
        {
            transform.Rotate(0f,0f,90f); 
        }
    }



}
