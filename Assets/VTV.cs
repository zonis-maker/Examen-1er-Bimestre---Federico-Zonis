using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    public string patente;
    public int modelo;
    public int kilometros;
    public int vencimiento;
    public int hcppm;
    // Start is called before the first frame update
    void Start()
    {
        if (patente == "")
        {
            Debug.Log("Error:patente no puede estar vacio.VTV no aprobada");
            return;
        }
        if (modelo < 1900 || modelo > 2025)
        {
            Debug.Log("Error:modelo no puede ser menor a 1900 ni mayor al año actual.VTV no aprobada");
            return;
        }
        if (kilometros < 0)
        {
            Debug.Log("Error:Kilometros no pueden ser negativos.VTV no aprobada");
            return;
        }
        if (vencimiento > 2025 || vencimiento < modelo)
        {
            Debug.Log("Error:El vencimiento no puede ser mayor al año actual ni al año de fabricacion.VTV no aprobada");
            return;
        }
        if (hcppm < 5||hcppm>100)
        {
            Debug.Log("Error:HCppm no puede ser menor a 5 ni mayor a 100.VTV no aprobada");
            return;
        }
        if (kilometros< 10000)
        {
            Debug.Log("Felicidades, tu VTV a sido aprobado por 2 años");
            return;
        }
        else if (kilometros > 10000)
        {
            Debug.Log("Felicidades, tu VTV a sido aprobado por 1 año");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
