using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float destroyX = -12f;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

