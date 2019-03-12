using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject fireworks;
    private bool game = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Capsule"))
        {
            Instantiate(fireworks, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            game = false;
        }
    }
}
