using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public string animal;
    public int dias;
    int gramos;
    bool correcto = true;

    // Start is called before the first frame update
    void Start()
    {
        if (dias > 2)
        {
            if (animal == "G")
            {
                gramos = dias * 300;
            }

            else if (animal == "PP")
            {
                gramos = dias * 400;
            }

            else if (animal == "PG")
            {
                gramos = dias * 700;
            }

            else
            {
                Debug.Log("Ingrese un código válido");
                correcto = false;
            }
        }

        else
        {
            Debug.Log("Ingrese una cantidad de días válida");
            correcto = false;
        }

        if (correcto)
        {
            Debug.Log("Para ese período se necesitan " + gramos + " gramos de alimento\nEsa cantidad costaría $" 
            + gramos / 100 * 80);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
