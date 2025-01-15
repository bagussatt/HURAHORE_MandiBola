using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruController : MonoBehaviour
{
    public GameObject bulletobj;
    public Transform bullerOut;
    float shootForce = 2000;

    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) {

        GameObject bulletClone = Instantiate(bulletobj, bullerOut.position, bullerOut.rotation);
            bulletClone.GetComponent<Rigidbody>().AddForce(shootForce * bullerOut.forward);
        }        
    }
}
