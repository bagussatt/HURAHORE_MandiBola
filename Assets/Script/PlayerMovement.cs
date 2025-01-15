using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController charController;
    public float moveSpeed = 10;
    public float rotateSpeed = 100;
    public Transform camera;
    public HealthBar playerHealth;

   
    private void Update()
    {
        Movement();
        ROtate();

    }
    void Movement()
    {
        float inputAD = 10;
        float inputWS = 10;
        Vector3 inputWASD;
        inputAD = Input.GetAxis("Horizontal");
        inputWS = Input.GetAxis("Vertical");
        inputWASD = new Vector3(inputAD, 0, inputWS);

        Vector3 moveCameradir = camera.TransformDirection(inputWASD);
        moveCameradir.y = 0;
        charController.SimpleMove(moveCameradir * moveSpeed);
    }
    void ROtate()
    {
        float inputMouseY;
        inputMouseY = Input.GetAxis("Mouse X");

        transform.eulerAngles += new Vector3(0, inputMouseY * rotateSpeed * Time.deltaTime, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            playerHealth.TakeDamage(5);
        }
        if (collision.transform.CompareTag("Boss"))
        {
            playerHealth.TakeDamage(50);
        }
    }

}

