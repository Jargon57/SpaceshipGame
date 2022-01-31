using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketControl : MonoBehaviour
{

    public float maxLeanAngle;
    public float rocketTurnSpeed;
    public float rocketTurnForce;

    Quaternion targetRotation;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Application.targetFrameRate = 60;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            targetRotation = Quaternion.Euler(0, 0, maxLeanAngle);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, 0, -maxLeanAngle);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rocketTurnSpeed);

        rb.AddForce(transform.right * rocketTurnForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Asteroid"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
