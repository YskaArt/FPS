using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveDamage : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }

}
