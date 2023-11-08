using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;



    // Start is called before the first frame update
    void Start()
    { 
        TryGetComponent( out source);
        restantes = FindObjectsOfType<moeda>().Length;

        hud.text = $"moeda restantes: {restantes}";
    }


    public void SubtrairMoedas(int valor)
    {
       restantes = restantes - valor;
       hud.text = $"moeda restantes: {restantes}";
       source.PlayOneShot(clipMoeda);
       
       if(restantes <= 0)
       {
        MsgVitoria.text = "parabens! voce ajudou wanda a encontrar a familia dela";
        source.Stop();
        source.PlayOneShot(clipVitoria);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
