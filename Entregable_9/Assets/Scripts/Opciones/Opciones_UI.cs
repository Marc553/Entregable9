using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opciones_UI : MonoBehaviour
{
    //Variables donde guardo todo el scrollbar junto al texto
    public GameObject letra1;
    public GameObject letra2;


    //Funcion del boton back
    public void GoToMainScene()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //Funcion que avanza a la siguiente letra, solo hacia alante
    public void AvLetra()
    {
        letra1.SetActive(false);
        letra2.SetActive(true);
    }

    //Funcion que retrocede a la letra anterior, solo hacia atras
    public void ReLetra()
    {
        letra2.SetActive(false);
        letra1.SetActive(true);
    }

}
