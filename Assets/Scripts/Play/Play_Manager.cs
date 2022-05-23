using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Play_Manager : MonoBehaviour
{
    public TextMeshProUGUI userName; //str
    public TextMeshProUGUI letter; //int
    public TextMeshProUGUI volume; //float
    private AudioSource   Musica; //bool

    void Start()
    {
        //Music = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        ApplyUserOptions();
    }

    public void ApplyUserOptions()
    {
        userName.text = $"{Data_persistence.SharedInfo.nombre} escribe con la mano:"; //nombre del personaje (str)

        volume.text = $"{(Data_persistence.SharedInfo.volumen * 100)} %"; //nos indica el % de volumen de la música en pantalla (float)

       
    }

}
