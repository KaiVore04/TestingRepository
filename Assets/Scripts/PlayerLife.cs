using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private int sweetsCol;
    private ItemCollector sweets;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        GameObject getSweets = GameObject.Find("Player Hold");
        sweets = getSweets.GetComponent<ItemCollector>();
        sweetsCol = sweets.sweets;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
        /*
         * if (collision.gameObject.CompareTag("Shadow") && sweetsCol >= 10)
         * {
         *     Destroy(collision.gameObject);
         * 
         * }
        */
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
