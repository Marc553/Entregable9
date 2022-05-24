using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class PlayManager : MonoBehaviour
{
    public TextMeshProUGUI userName; //str
    public TextMeshProUGUI letter; //int
    public TextMeshProUGUI volume; //float
    private AudioSource controladorAudio;
    private int contadorEscenas;

    public TextMeshProUGUI contadorVisible;
    public TextMeshProUGUI contadorVisible2;

    public AudioClip saoko;
    public AudioClip bizcochito;

    public GameObject manoizq;
    public GameObject manoder;

    void Start()
    {
        controladorAudio = GameObject.Find("Camara").GetComponent<AudioSource>();
        controladorAudio.volume = Datapersistence.SharedInfo.volumen;
        ApplyUserOptions();
        ActivacionManos();
        Cancion();
        contadorEscenas = Datapersistence.SharedInfo.SceneChanges;
    }

    public void ApplyUserOptions()
    {
        userName.text = $"{Datapersistence.SharedInfo.nombre} escribe con la mano:"; //nombre del personaje (str)
        contadorVisible.text = $"{Datapersistence.SharedInfo.SceneChanges}";
        contadorVisible2.text = $"{Datapersistence.SharedInfo.PreviousSceneChanges}";
    }

    #region Funcion Manos
    public void ActivacionManos()
    {
        if(Datapersistence.SharedInfo.mano == 0)
        {
            manoder.SetActive(false);
            manoizq.SetActive(true);
        }
        else
        {
            manoizq.SetActive(false);
            manoder.SetActive(true);
        }
    }
    #endregion

    #region Letra cancion

    public void Cancion()
    {
        if(Datapersistence.SharedInfo.letra == 0)
        {
            letter.text = "Y le gusta la canción SAOKO de Rosalía";
            controladorAudio.PlayOneShot(saoko);
        }
        else
        {
            letter.text = "Y le gusta la canción BIZCOCHITO de Rosalía";
            controladorAudio.PlayOneShot(bizcochito);
        }
    }

    

    #endregion

    public void Exit()
    {
        Datapersistence.SharedInfo.PreviousSceneChanges = Datapersistence.SharedInfo.SceneChanges;
        UnityEditor.EditorApplication.isPlaying = false;

    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        contadorEscenas++;
        Datapersistence.SharedInfo.SceneChanges = contadorEscenas;
        // Cargamos la escena que tenga por nombre sceneName
        
       
    }


}