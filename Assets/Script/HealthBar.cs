using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int maxHealth = 100; 
    private int currentHealth; 
    public Slider Slider;


    void Start()
    {
        currentHealth = maxHealth; 
        Slider.maxValue = maxHealth;
        Slider.value = currentHealth;
       
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            TakeDamage(25);
            Debug.Log("nyawa berkurang");
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; 
        Slider.value = currentHealth;

        if (currentHealth <= 0)
        {
           
            Die(); 
        }
    }

    void Die()
    {

        Debug.Log("Player has died!");
        SceneManager.LoadScene(3);
    }
}
        
