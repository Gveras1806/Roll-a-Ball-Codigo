using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{
    public Vector3 startPoint;
    public float moveDistance = 10.0f; // Distancia m�xima de movimiento
    public float speed = 1.0f;
    private Vector3 originalPosition;
    private float movementDirection = 1.0f; // Direcci�n inicial de movimiento (+1 hacia adelante, -1 hacia atr�s)

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime; // Calcula el paso basado en el tiempo

        // Calcula el punto final basado en la direcci�n de movimiento y la distancia m�xima
        Vector3 endPoint = originalPosition + movementDirection * Vector3.forward * moveDistance;

        // Mueve el objeto hacia el endPoint, limitando el movimiento a moveDistance
        transform.position = Vector3.MoveTowards(transform.position, endPoint, step);

        // Cambia la direcci�n si alcanza el punto final
        if (transform.position == endPoint)
        {
            movementDirection *= -1; // Invierte la direcci�n
        }
    }
}
