using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Autor: Melissa Estela Oscoy Parada
//Materia: Estructura de datos 
//Profesor: Josue Israel Rivas Diaz
//Practica: sierras
public class Sierra_lateral : MonoBehaviour
{
    //guarda el punto del que parte la sierra
    private Vector3 OriginalTransform;

    //hace que se mueva el objeto
    public float velocidad;

    //se ve la distancia de recorrido
    public float distancia;

    void Start()
    {
        //aqui sale la posicion,rotacion y escala que tiene el objeto dueño de este codigo
        OriginalTransform = this.transform.position;
    }


    void Update()
    {
        //permite que la sierra se mueva de un punto de origen a otro y que regrese mediante un movimiento matematico
        transform.position = OriginalTransform + new Vector3(Mathf.Sin(Time.time * velocidad) * distancia, 0, 0);

    }
}