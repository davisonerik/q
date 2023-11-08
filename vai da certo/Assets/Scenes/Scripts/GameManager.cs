using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, MsgVitoria;
    public int restantes;



    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<moeda>().Length;

        hud.text = $"moeda restantes: {restantes}";
    }


    public void SubtrairMoedas(int valor)
    {
       restantes = restantes - valor;
       hud.text = $"moeda restantes: {restantes}";
       if(restantes <= 0)
       {
        MsgVitoria.text = "parabens!";
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}