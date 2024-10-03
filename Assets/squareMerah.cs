using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareMerah : MonoBehaviour
{
    public float moveSpeed = 5f;  // Kecepatan gerak square merah

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    public VariableJoystick joystick;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Menggunakan arrow keys secara spesifik, tanpa Input Manager default
        // float moveX = 0f;
        // float moveY = 0f;

        // if (Input.GetKey(KeyCode.LeftArrow)) { moveX = -1f; }  // Kiri
        // if (Input.GetKey(KeyCode.RightArrow)) { moveX = 1f; }  // Kanan
        // if (Input.GetKey(KeyCode.UpArrow)) { moveY = 1f; }     // Atas
        // if (Input.GetKey(KeyCode.DownArrow)) { moveY = -1f; }  // Bawah

        // moveDirection = new Vector2(moveX, moveY).normalized;  // Menormalkan agar kecepatan tetap konsisten

        if (joystick != null)
        {
            float joyX = joystick.Horizontal;
            float joyY = joystick.Vertical;
            moveDirection = new Vector2(joyX, joyY);
        }
        else
        {
            Debug.LogWarning("Joystick is not assigned!");
        }
    }

    void FixedUpdate()
    {
        // Menggerakkan square merah menggunakan Rigidbody2D
        rb.velocity = moveDirection * moveSpeed;
    }
}
