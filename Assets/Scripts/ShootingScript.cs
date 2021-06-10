using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Camera camera;
    public GameObject bullet;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet);
            bullet.transform.position = camera.transform.position + camera.transform.forward;
            bullet.transform.forward = camera.transform.forward;
        }
    }
}
