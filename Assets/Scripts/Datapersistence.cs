using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datapersistence : MonoBehaviour
{
    public static Datapersistence SharedInfo;

    //datos que querremos conservar de una escena a otra
    public int letra; //numero del array de letras, para saber en cual estas
    public float volumen; //valor del slider de volumen
    public int mano; //valor 0 o 1 del bool, saber con que mano escribes
    public string nombre; //nombre del player
    
    public int SceneChanges; //escena actual 
    public int PreviousSceneChanges; //escena anterior

    //Para que la instancia sea única
    private void Awake()
    {

        //Si la instancia no existe
        if (SharedInfo == null)
        {
            //Configuramos la instancia
            SharedInfo = this;
            //Nos aseguramos de que no sea destruida con el cambio de escena
            DontDestroyOnLoad(SharedInfo);
        }
        else
        {
            //Como ya existe una instancia, destruimos la copia
            Destroy(this);
        }
    }

    public void SaveForFutureGames()
    {
        //Letra
        PlayerPrefs.SetInt("LETRA", letra);

        //volumen
        PlayerPrefs.SetFloat("VOLUMEN", volumen);

        //bool de mano

        PlayerPrefs.SetInt("MANO", mano);

        //Nombre del player
        PlayerPrefs.SetString("NOMBRE", nombre);

        //escenas actuales
        PlayerPrefs.SetInt("ESCENACTUAL", SceneChanges);

        //ecena anterior
        PlayerPrefs.SetInt("ESCENANTERIOR", PreviousSceneChanges);

    }

    //para salir del juego 
    public void OnApplicationQuit()
    {
        PreviousSceneChanges = Datapersistence.SharedInfo.SceneChanges;
        SaveForFutureGames();
    }

}
