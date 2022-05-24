using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class Options_Manager : MonoBehaviour
{/*
    public AudioSource controladorAudio;
    public AudioClip musicaMenu;

    public GameObject[] letras;
    public int letra; //valor int a guardar

    public Slider volumeSlider; //donde sacaremos el value (float)
    

    public Toggle mano; //donde sacaremos el isOn (bool que se convierte en int)

    public TMP_InputField nombre;//de donde sale el string


    public TextMeshProUGUI SceneChanges;
    public TextMeshProUGUI LastSceneChanges;


    
    private float volumeLevel;//registrar a que value está el slider (float)
    private int zurdo; //int que estará asociado el valor del toogle
    private string nome; //Para guardar el nombre del personaje Elegido (str)
    private int LastSceneChangeCounter;

    private void Start()
    {
        controladorAudio = FindObjectOfType<AudioSource>();
        controladorAudio.PlayOneShot(musicaMenu);

        LoadUserOptions();
        SaveUserOptions();

    }

    public void SaveUserOptions() //cuando se ejecuta guarda en el data persitance las variables en su respectiva caja
    {
        // Persistencia de datos entre escenas
        Data_persistence.SharedInfo.volumen = volumeLevel;

        Data_persistence.SharedInfo.mano = zurdo;

        Data_persistence.SharedInfo.nombre = nome;

        Data_persistence.SharedInfo.letra = letra;

       
        // Persistencia de datos entre partidas
        Data_persistence.SharedInfo.SaveForFutureGames();
    }

    public void LoadUserOptions()
    {
        // Tal y como lo hemos configurado, si tiene esta clave, entonces tiene todas
        if (PlayerPrefs.HasKey("LETRA"))
        {
            //ChangeLevelSelection();
           letra = PlayerPrefs.GetInt("LETRA"); //Lo actualiza el changeLevelSelection

            volumeLevel = PlayerPrefs.GetFloat("VOLUMEN"); //obtenemos el volumen de la partida anterior
            LoadVolume(); //y lo metemos en el slider

            zurdo = PlayerPrefs.GetInt("MANO"); //obtenemos si estaba apagada o encendida la música antes
           
            LoadToogle(); //cambiamos el toogle según si estaba apagada o encendida

            name = PlayerPrefs.GetString("NOMBRE");


            LastSceneChangeCounter = PlayerPrefs.GetInt("PREVIOUS_CHANGES");
            LastSceneChanges.text = ($"Last Scene Changes: {LastSceneChangeCounter}");

        }
    }

    public void LoadVolume() //metemos el valor de volume level en el slider del menú de opciones, para cargar datos de partidas previas
    {
        volumeSlider.GetComponent<Slider>().value = volumeLevel;
    }
    public void VolumeSelection() //para que cuando cambiemos el valor del slider guardemos el valor para pasarlo al datapersistance
    {
        volumeLevel = volumeSlider.GetComponent<Slider>().value;
    }

    public void LoadToogle() //activa o desactiva el toggle segun el valor guardado en playerPrefs de la partida anterior.
    {
        if (zurdo == 0)
        {
            VolumeToogle.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            VolumeToogle.GetComponent<Toggle>().isOn = false;
        }
    }

    public void BoolMano() //al cambiar el valor del toggle podremos cambiar el valor del int que meteremos en data persistance
    {
        musicToogle = mano.GetComponent<Toggle>().isOn;
        if (musicToogle == true)
        {
            zurdo = 0;
        }
        else
        {
            zurdo = 1;
        }
    }

    public void GoToScene(string sceneName)
    {
        // Cargamos la escena que tenga por nombre sceneName
        SceneManager.LoadScene(sceneName);
    }

    public void AvLetra()
    {   
        letra = 1;
        if(letra == 1)
        {
            letras[0].SetActive(false);
            letras[1].SetActive(true);
        }
    }

    public void ReLetra()
    {
        letra = 0;
        if (letra == 0)
        {
            letras[1].SetActive(false);
            letras[0].SetActive(true);
        }
    }
    */
}
