using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Hay que incluir esta dependencia!
using UnityEngine.AI;

public class MovimientoAgente : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform destino;
    public Vector3 inicio;
    void Start()
    {
        inicio = transform.position;
        /* TODO: Obtener una referencia al agente, y establecer como destino las coordenadas del objeto 'Premio' */
        agent = GetComponent<NavMeshAgent>();
        agent.destination = destino.position;

    }

    // ¿Hace falta poner el Update?
    void Update()
    {
        Debug.Log("Mis coordenadas: " + transform.position + "Y las coordenadas del colega" + destino.position);
        if (transform.position.x == destino.position.x)
        {
            agent.destination = inicio;
        }
    }
}
