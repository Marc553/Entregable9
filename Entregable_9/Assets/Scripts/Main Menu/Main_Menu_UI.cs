using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_UI : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        // Se carga la escena que se haya escrito en el inspector(la de opciones)
        SceneManager.LoadScene(sceneName);
    }
}
