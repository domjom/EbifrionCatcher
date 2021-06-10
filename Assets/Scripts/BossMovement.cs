using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float speed;
    public bool isMovingRight = true;

    public GameObject ebifrion;
    public GameObject bomb;
    private Vector3 spawnLocation;

    public static float minTime = 1.0f;
    public static float maxTime = 3.0f;

    private float time;
    private float spawnRate;

    private void Start()
    {
        maxTime = 3.0f;
        minTime = 1.0f;
        randomTimeSelector();
    }

    void Update()
    {
        if(isMovingRight == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        time += Time.deltaTime;

        if(time >= spawnRate)
        {
            int randomSelector = Random.Range(0, 3);
            if (randomSelector == 1)
            {
                spawnLocation = new Vector3(transform.position.x + 1.0f, transform.position.y + 4.0f, transform.position.z);
                Instantiate(bomb, spawnLocation, bomb.transform.rotation);
                time = 0;
                randomTimeSelector();
            }

            else
            {
                spawnLocation = new Vector3(transform.position.x + 1.0f, transform.position.y + 4.0f, transform.position.z);
                Instantiate(ebifrion, spawnLocation, ebifrion.transform.rotation);
                time = 0;
                randomTimeSelector();
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ResetBoss")
        {
            if (isMovingRight == true)
            {
                isMovingRight = false;
            }

            else
            {
                isMovingRight = true;
            }
        }
    }

    void randomTimeSelector()
    {
        spawnRate = Random.Range(minTime, maxTime);
    }
}
