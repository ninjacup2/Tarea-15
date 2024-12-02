using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadEnemigo : MonoBehaviour
{
    public Rigidbody2D Nave;
    public float Velocity = -2f;

    public GameManagerControl gameManager;
    void Awake()
    {
        Nave = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Nave.velocity = new Vector2(0, Velocity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bala")
        {
            gameManager.UpdateScore(100);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    public void SetGameManager(GameManagerControl gm)
    {
        gameManager = gm;
    }
}
