using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basicmovement : MonoBehaviour
{

    public float movementSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + movement * Time.deltaTime * movementSpeed;

    }

}
