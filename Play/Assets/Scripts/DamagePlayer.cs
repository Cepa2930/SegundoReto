    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer: MonoBehaviour,IDaño
{
    public static bool damageSignal = false;
    public static float damageTime = 0f;
    public  GameObject gameOver;
    public GameObject player;
    public GameObject pause;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            damageSignal = true;
            damageTime = 0f;
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
