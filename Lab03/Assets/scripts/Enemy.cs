using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    Rigidbody rBody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = -15f;
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector3(0, 0, speed);
    }

}
