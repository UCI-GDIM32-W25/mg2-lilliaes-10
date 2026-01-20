using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public float jumpForce = 0.3f;
    private Rigidbody2D rb;
    private bool isGrounded;

    [SerializeField] private TextMeshProUGUI Pointstext;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UpdateScoreUI();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            AddPoint();
            Debug.Log("hi");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            AddPoint();
            Debug.Log("hi");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    
    private int score = 0;

    public void AddPoint()
    {
        score++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        Pointstext.text = "Points: " + score;
    }
}
