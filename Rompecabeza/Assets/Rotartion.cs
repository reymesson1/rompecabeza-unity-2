using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotartion : MonoBehaviour {

    //rotacion on click
    [SerializeField]
    private Transform[] picture;

    [SerializeField]
    public GameObject wintext;
    


    public static bool youwin;


    void Start()
    {
        wintext.SetActive(false);
        youwin = false;
    }

    void Update()
    {
        if (picture[0].rotation.z == 0 &&
            picture[1].rotation.z == 0 &&
            picture[3].rotation.z == 0 &&
            picture[4].rotation.z == 0 &&
            picture[5].rotation.z == 0 &&
            picture[6].rotation.z == 0 &&
            picture[7].rotation.z == 0 &&
            picture[8].rotation.z == 0 
            )
        {
            
            youwin = true;
            wintext.SetActive(true);
            
            Time.timeScale = 0;
        }   
    }


    private void OnMouseDown()
    {
        
        transform.Rotate(0f, 0f, 90f);
        //Debug.Log("prueva");
    }
}
