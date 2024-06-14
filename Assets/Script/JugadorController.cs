using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JugadorController : MonoBehaviour
{
    public float timeRemaining = 60.0f;
public Text timerText;
    private Rigidbody rb;
    public float velocidad;
    private int contador;
    public Text textoContador, textoGanar;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
       setTextoContador();
    }

     void setTextoContador()
    {
        textoContador.text = "Contador= " + contador.ToString();
        if(contador >= 12)
        {
            textoGanar.text = "GANASTE!";
            Proximo();
            
        }
    }
    void Proximo()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            StartCoroutine(WaitAndLoadMenu(2.0f));
        }
    }
        private IEnumerator WaitAndLoadMenu(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Floor(timeRemaining).ToString();
        }
        else
        {
            timerText.text = "Tiempo agotado!" +
                "  " +
                " PERDISTE";
            StartCoroutine(WaitAndLoadMenu(2.0f));
        }
    }

    void FixedUpdate()
    {
        float MovimientoH = Input.GetAxis("Horizontal");
        float MovimientoV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(MovimientoH, 0.0f, MovimientoV);

        rb.AddForce(movimiento * velocidad);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            other.gameObject.SetActive(false);

            contador = contador + 1;
            setTextoContador();
        }
    }
}
