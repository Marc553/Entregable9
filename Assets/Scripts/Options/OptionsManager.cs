using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class OptionsManager : MonoBehaviour
{
    private AudioSource controladorAudio;
    public AudioClip musicaMenu;

    public GameObject[] letras;//array donde guardar la letra
   
    public Slider volumeSlider; //donde sacaremos el valor (float)
    public Toggle mano; //donde sacaremos el isOn (bool que se convierte en int)
    public TMP_InputField nombre;//de donde sale el string

     private int letra; //valor int a guardar
    private float numeroVolumen;//valor del slider (float)
    private int intBoolMano;//int asociado a la respuesta del toggle
    private bool manoBool; //para saber si queremos la música activa o no (bool)
    public int contadorEscenas;

    public TextMeshProUGUI contadorVisible;
    public TextMeshProUGUI contadorVisible2;

    public TextMeshProUGUI SceneChanges;
    public TextMeshProUGUI LastSceneChanges;

    private void Start()
    {
        controladorAudio = GameObject.Find("Camara").GetComponent<AudioSource>();
        controladorAudio.volume = Datapersistence.SharedInfo.volumen;
        controladorAudio.PlayOneShot(musicaMenu);
        LoadUserOptions();
        SaveUserOptions();

        contadorVisible.text = $"{Datapersistence.SharedInfo.SceneChanges}";
        contadorVisible2.text = $"{Datapersistence.SharedInfo.PreviousSceneChanges}";
    }

    public void SaveUserOptions() //cuando se ejecuta guarda en el data persitance las variables en su respectiva caja
    {
        //persistencia de datos entre escenas
        Datapersistence.SharedInfo.letra = letra;

        Datapersistence.SharedInfo.volumen = numeroVolumen;

        Datapersistence.SharedInfo.mano = intBoolMano;

        Datapersistence.SharedInfo.nombre = nombre.text;

        Datapersistence.SharedInfo.SceneChanges = contadorEscenas;

        //persistencia de datos entre partidas
        Datapersistence.SharedInfo.SaveForFutureGames();
    }

    public void LoadUserOptions()
    {
        //si tiene esta clave, entonces tiene todas
        if (PlayerPrefs.HasKey("LETRA"))
        {
            letra = PlayerPrefs.GetInt("LETRA");//coge el valor guardado y lo actualiza en el hueco del nombre

            numeroVolumen = PlayerPrefs.GetFloat("VOLUMEN");//coge el último valor que ha tenido el slider
            LoadVolume();

            intBoolMano = PlayerPrefs.GetInt("MANO");//ver si el bool esta activado o no
            LoadToogle();//actualiza el toggle

            nombre.text = PlayerPrefs.GetString("NOMBRE");//agarra el string del nombre guardado previamente

            contadorEscenas = PlayerPrefs.GetInt("ESCENACTUAL"); //me carga el numero anteriror de escenas pasadas
            
            contadorVisible2.text = PlayerPrefs.GetInt("ESCENANTERIOR").ToString();
            
            //guarda la persistencia de datos entre partidas
            Datapersistence.SharedInfo.SaveForFutureGames();
        }
    }

    #region UpdateVolume
    public void LoadVolume() //metemos el valor de numeroVolumen en el slider del menú de opciones, para cargar el volumen que se tenia configurado en otras partidas
    {
        volumeSlider.GetComponent<Slider>().value = numeroVolumen;
    }
    public void VolumeSelection() //para que cuando cambiemos el valor del slider guardemos el valor para pasarlo al datapersistance
    {
        numeroVolumen = volumeSlider.GetComponent<Slider>().value;
    }
    #endregion

    #region Mano Toogle
    public void LoadToogle() //activa o desactiva el toggle segun el valor guardado en playerPrefs de la partida anterior
    {
        if (intBoolMano == 0)
        {
            mano.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            mano.GetComponent<Toggle>().isOn = false;
        }
    }

    public void BoolMano() //al cambiar el valor del toggle podremos cambiar el valor del int que meteremos en data persistance
    {
        manoBool = mano.GetComponent<Toggle>().isOn;
        if (manoBool == true)
        {
            intBoolMano = 0;
        }
        else
        {
            intBoolMano = 1;
        }
    }
    #endregion

    #region Option Menu
    public void GoToScene(string sceneName)
    {
        // Cargamos la escena que tenga por nombre sceneName
        SceneManager.LoadScene(sceneName);
        contadorEscenas++;
        SaveUserOptions();
    }

    public void AvLetra()
    {
        letra = 1;
        if (letra == 1)
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

    #endregion
}
