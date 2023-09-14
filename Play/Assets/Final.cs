using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    [SerializeField] private int cantidadBombillos;
    [SerializeField] private int bombillosRecolectados;

    void Start()
    {
        cantidadBombillos = GameObject.FindGameObjectsWithTag("Bombillos").Length;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && bombillosRecolectados == cantidadBombillos)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
   
}
