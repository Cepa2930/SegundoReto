using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murcielago : MonoBehaviour,IDaño
{
    [SerializeField] public Transform jugador;
    [SerializeField] private float distancia;

    public Vector3 puntoInicial;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public GameObject gameOver;
    public GameObject player;
    public GameObject pause;

    private void Start()
    {
        animator = GetComponent<Animator>();
        puntoInicial = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        distancia = Vector2.Distance(transform.position, jugador.position);
        animator.SetFloat("Distancia", distancia);
    }
    public void Girar(Vector3 obejtivo)
    {
        if (transform.position.x < obejtivo.x)  
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipY = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<HeroKnight>().RecibirDaño(20);
            pause.SetActive(false);
            gameOver.SetActive(true);
            player.SetActive(false);
        }
    }
    public void TomarDaño(float daño)
    {
        Destroy(gameObject);
    }
}
