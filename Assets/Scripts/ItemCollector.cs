using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] public int sweets = 0;

    [SerializeField] private Text sweetsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sweet"))
        {
            Destroy(collision.gameObject);
            sweets++;
            Debug.Log("Sweets: " + sweets);
            sweetsText.text = "Sweets: " + sweets;
        }
        if (collision.gameObject.CompareTag("SuperSweet"))
        {
            Destroy(collision.gameObject);
            sweets += 2;
            Debug.Log("Sweets: " + sweets);
            sweetsText.text = "Sweets: " + sweets;
        }
        if (collision.gameObject.CompareTag("Pills"))
        {
            Destroy(collision.gameObject);
            sweets -= 5;
            Debug.Log("Sweets: " + sweets);
            sweetsText.text = "Sweets: " + sweets;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Shadow") && sweets >= 10)
        {
            Destroy(collision.gameObject);
            sweets -= 10;
            Debug.Log("Sweets: " + sweets);
            sweetsText.text = "Sweets: " + sweets;
        }
    }
}
