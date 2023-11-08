using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed = 20;
    public GameObject particle;


    void Start()
    {
        Destroy(gameObject,2f);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boom")
        {
            Destroy(collision.gameObject);
            for (int i = 0; i < 150; i++)
            {
                var offset = Random.insideUnitSphere;
                Instantiate(particle, transform.position + offset , transform.rotation);
            }
        }
        Destroy(gameObject);
       
    }
}
