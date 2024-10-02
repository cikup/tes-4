using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareBiru : MonoBehaviour
{
    public float moveSpeed = 5f;  // Kecepatan gerak square biru

    private Rigidbody2D rb;
    private Vector2 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input untuk WASD
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.A)) { moveX = -1f; }  // W = Kiri
        if (Input.GetKey(KeyCode.D)) { moveX = 1f; }   // D = Kanan
        if (Input.GetKey(KeyCode.W)) { moveY = 1f; }   // W = Atas
        if (Input.GetKey(KeyCode.S)) { moveY = -1f; }  // S = Bawah

        moveDirection = new Vector2(moveX, moveY).normalized;  // Menormalkan agar kecepatan tetap konsisten
    }

    void FixedUpdate()
    {
        // Menggerakkan square biru menggunakan Rigidbody2D
        rb.velocity = moveDirection * moveSpeed;
    }
}
