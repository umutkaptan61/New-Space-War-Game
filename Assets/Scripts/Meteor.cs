using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Vector3 rotateVector;

    public float rotateSpeed;
    public float movementSpeed;

    public GameObject meteorDestroyEffect;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(rotateVector * rotateSpeed * Time.fixedDeltaTime);
        transform.position += new Vector3(0f, -1f, 0f) * Time.deltaTime * movementSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerShip"))
        {
            Instantiate(meteorDestroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("BulletCatcher"))
        {
            Destroy(gameObject);
        }
    }
}
