using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        speed = 30;
        score = 0;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            score++;
            other.gameObject.SetActive(false);
            Debug.Log("Score: " + score);
        }
    }

    void MovePlayer()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
