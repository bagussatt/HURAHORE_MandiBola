using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 5f;      
    public Transform player; 
    public float chaseDistance = 10f;     
    private int hitCount = 0;  
    private const int maxHits = 3; 
    void Start()
    {
            
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
      
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
   
        if (distanceToPlayer < chaseDistance)
        {
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
    
        Vector3 direction = (player.position - transform.position).normalized;

  
        direction.y = 0;

   
        transform.position += direction * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Light playerLight = collision.gameObject.GetComponent<Light>();
            if (playerLight != null)
            {
                playerLight.enabled = true;
                StartCoroutine(TurnOffLightAfterDelay(playerLight, 2f));
            }
        }

        if (collision.transform.CompareTag("Peluru"))
        {
            hitCount++;
            Debug.Log("Enemy Hit: " + hitCount + "/" + maxHits);

  
            MainManager.Instance.AddScore(20);
            Debug.Log("Score after hit: " + MainManager.Instance.score);

            Destroy(collision.gameObject); 

            if (hitCount >= maxHits)
            {
                Destroy(gameObject);
                Debug.Log("Enemy Destroyed");
            }
        }
    }

    private IEnumerator TurnOffLightAfterDelay(Light playerLight, float delay)
    {
        yield return new WaitForSeconds(delay);
        playerLight.enabled = false; 
    }
}
