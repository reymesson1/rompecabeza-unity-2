using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

    public int tiempoInicial;
    public float escalaDeTiempo = 1;
    private Text myText;
    private float tiempoDelFrameConTimeScale = 0;
    private float tiempoAMostrarEnSegundo = 0;
    private float escalaDeTiempoAlPausar, escalaDeTimpoInicial;
    private bool estaPausado = false;
    void Start()
    {

        escalaDeTimpoInicial = escalaDeTiempo;

        myText = GetComponent<Text>();

        tiempoAMostrarEnSegundo = tiempoInicial;

        ActualizarRelok(tiempoInicial);




    }

    // Update is called once per frame
    void Update()
    {

        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;

        tiempoAMostrarEnSegundo += tiempoDelFrameConTimeScale;

        ActualizarRelok(tiempoAMostrarEnSegundo);





    }

    public void ActualizarRelok(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;


        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;



        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        myText.text = textoDelReloj;
        
    }
}
