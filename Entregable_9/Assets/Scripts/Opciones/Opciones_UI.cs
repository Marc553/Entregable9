using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opciones_UI : MonoBehaviour
{
    public GameObject letra1;
    public GameObject letra2;

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void AvLetra()
    {
        letra1.SetActive(false);
        letra2.SetActive(true);
    }
    public void ReLetra()
    {
        letra2.SetActive(false);
        letra1.SetActive(true);
    }

}
