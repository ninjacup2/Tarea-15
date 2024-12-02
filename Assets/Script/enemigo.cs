using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public GameObject explosión;
    public float tiempoDestrucción = 2f;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            GameObject nuevaExplosión = Instantiate(explosión, transform.position, transform.rotation);
            Destroy(nuevaExplosión, tiempoDestrucción);
            Destroy(gameObject);
        }
    }
}
