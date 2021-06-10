using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float forceZ;
    public float forceY;

    Vector3 startForce;

    void Start()
    {
        startForce = new Vector3(0.0f, forceY, -forceZ);
        GetComponent<Rigidbody>().AddForce(startForce, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Despawner")
        {
            Destroy(gameObject);
        }

        if (col.tag == "Bullet")
        {
            Destroy(gameObject);
            GameManager.lifeRemaining--;
            Debug.Log(GameManager.lifeRemaining);
        }
    }
}
