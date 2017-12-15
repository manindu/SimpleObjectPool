using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

    [SerializeField] float speed = 5f;
    [SerializeField] float deactivationDelay = 5f;

    void Start()
    {
        Invoke("Deactivate", deactivationDelay);
    }

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
