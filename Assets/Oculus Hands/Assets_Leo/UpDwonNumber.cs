using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IncrementText : MonoBehaviour
{
    public TextMeshProUGUI texto;
    private int valor = 0;

    // Método que se ejecuta cuando se presiona el botón
    public void IncrementarTexto()
    {
        if (valor < 10){
            valor++;
            texto.text = valor.ToString();
        }
        
    }

    public void DecrementarTexto()
    {
        if (valor > 1){
            valor--;
            texto.text = valor.ToString();
        }
        
    }
}
