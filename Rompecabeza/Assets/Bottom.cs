using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bottom : MonoBehaviour {

    // Use this for initialization
    public GameObject pausemenu;
    public GameObject pausebuttom;

	
	

    public void cambiodescena()
    {
        //btn play(menu)
        SceneManager.LoadScene("Gameplay");


    }

    public void pause()
    {
        pausemenu.SetActive(true);
        
        Time.timeScale = 0;
    }

    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1;
        
    }

    public void restart()
    {
        Time.timeScale = 1;
        pausemenu.SetActive(false);
        SceneManager.LoadScene("Gameplay");
    }

}
