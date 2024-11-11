using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEditor;
using TMPro;
using UnityEngine.EventSystems;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    [SerializeField] private TextMeshProUGUI healthText;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }
    private void OnMouseDown()
    {
        TakeDamage(1);
    }
    private void TakeDamage(int damage)
    {
        currentHealth = Mathf.Max(currentHealth - damage, 0);

        UpdateHealthText();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = $"Health: {currentHealth}";
        }
    }

    private void Die()
    {
        Debug.Log("Enemy defeated!");
        Destroy(gameObject);
    }
}
