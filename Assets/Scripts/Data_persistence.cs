using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_persistence : MonoBehaviour
{
    public static Data_persistence SharedInfo;

    //datos que querremos conservar de una escena a otra
    public int letra; //numero de l array de letras, para saber en cual estas
    public float volumen; //valor del slider de volume
    public int mano; //valor 0 o 1 del bool
    public string nombre; //nombre del personaje elegido
    public int CharacterSlotInt;
    public int SceneChanges;
    public int PreviousSceneChanges;

    //Para que la instancia sea única
    private void Awake()
    {

        // Si la instancia no existe
        if (SharedInfo == null)
        {
            // Configuramos la instancia
            SharedInfo = this;
            // Nos aseguramos de que no sea destruida con el cambio de escena
            DontDestroyOnLoad(SharedInfo);
        }
        else
        {
            // Como ya existe una instancia, destruimos la copia
            Destroy(this);
        }
    }
    public void SaveForFutureGames()
    {
        // Level
        PlayerPrefs.SetInt("LETRA", letra);

        // volume
        PlayerPrefs.SetFloat("VOLUMEN", volumen);

        //Music

        PlayerPrefs.SetInt("MANO", mano);

        // Nombre de usuario
        PlayerPrefs.SetString("NOMBRE", nombre);

    }

    public void OnApplicationQuit()
    {
        PreviousSceneChanges = Data_persistence.SharedInfo.SceneChanges;
        SaveForFutureGames();
    }
}
