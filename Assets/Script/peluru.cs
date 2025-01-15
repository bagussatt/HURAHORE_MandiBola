using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour
{
    public GameSceneManager gameSceneManager;
    private void Start()
    {
        StartCoroutine(LifeTime());
    }
    IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.CompareTag("Enemy")) 
        {   
            Debug.Log("Enemy Hit"); 
            Destroy(gameObject); 
        }
    }
}
