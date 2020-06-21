using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke("Respawn", 3);
        }

    }
    void Respawn()
        {
            gameObject.SetActive(true);
        }
}
