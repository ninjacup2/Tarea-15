using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nave : MonoBehaviour
{
    Rigidbody2D _componentRigidbody2D;
    public float velocity;
    private float vertical;
    private float horizontal;
    public GameObject prefab;
    public AudioSource disparo;

    // Start is called before the first frame update
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(prefab,transform.position,transform.rotation);
            disparo.Play();
        }
    }
    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(horizontal * velocity, vertical * velocity);
    }
}