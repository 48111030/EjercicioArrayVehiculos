using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
   

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Se desactiven todos los vehiculos y se active un vehiculo al azar del array
            for (int i = 0; i < vehiculos.Length; i++)
            {
                vehiculos[i].SetActive(false);
            }
            vehiculos[ Random.Range(0,vehiculos.Length)].SetActive(true);
        }   
    }

    void ResetearVehiculos()
    {
        //desactivar todos los elementos del array

        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }

        //activar solo el primer elemento
        vehiculos[0].SetActive(true);
    }
}
