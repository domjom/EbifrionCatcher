using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Invoke("Despawner", 5.0f);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void Despawner()
    {
        Destroy(gameObject);
    }
}
