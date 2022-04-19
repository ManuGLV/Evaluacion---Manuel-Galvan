using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej : MonoBehaviour
{
    public int gramos;
    public string gusto = "";
    // Start is called before the first frame update
    void Start()
    {
        int precio = gramos * 500 / 1000;
        int desc = precio * 10 / 100;
        int preciofr = precio - desc;

        
        if (gramos < 250)
        {
            Debug.Log("No es una cantidad valida");
        }
        else if(gramos > 3000)
        {
            Debug.Log("No es una cantidad valida");
        }
        else 
        {
            switch (gusto)
            {
                case "CHO": Debug.Log("El costo de su pedido es de " + precio + " pesos");
                    break;
                case "DDL": Debug.Log("El costo de su pedido es de " + precio + " pesos");
                    break;
                case "FRU": Debug.Log("El costo de su pedido es de " + preciofr + " pesos");
                    break;
                default: Debug.Log("No es un codigo valido");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
