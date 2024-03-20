using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IncrementHour : MonoBehaviour
{
    public TextMeshProUGUI hora;
    public TextMeshProUGUI minutos;
    private int valorHola = 0;
    private int valorMinutos = 0;

    // Método que se ejecuta cuando se presiona el botón
    public void IncrementarHora()
    {
        if (valorHola < 23){
            valorHola++;
            hora.text = valorHola.ToString("00");
        }else{
            valorHola = 0;
            hora.text = valorHola.ToString("00");
        }
        
    }
    public void DecrementarHora()
    {
        if (valorHola > 0){
            valorHola--;
            hora.text = valorHola.ToString("00");
        }else{
            valorHola = 23;
            hora.text = valorHola.ToString("00");
        }
        
    }



    public void IncrementarMin()
    {
        if (valorMinutos < 59){
            valorMinutos++;
            minutos.text = valorMinutos.ToString("00");
        }else{
            valorMinutos = 0;
            minutos.text = valorMinutos.ToString("00");
        }
        
    }
    public void DecrementarMin()
    {
        if (valorMinutos > 0){
            valorMinutos--;
            minutos.text = valorMinutos.ToString("00");
        }else{
            valorMinutos = 59;
            minutos.text = valorMinutos.ToString("00");
        }
        
    }


}
    

