using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public float velocity;
    private GameManagerControl gameManagerControl;
    // Start is called before the first frame update
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
        gameManagerControl = GameObject.Find("GameManager").GetComponent<GameManagerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(0, velocity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            gameManagerControl.UpdateScore(50);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Muros")
        {
            Destroy(this.gameObject);
        }
    }
}
