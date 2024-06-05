using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float detectionRange = 10f; // Jarak deteksi pemain

    private Rigidbody2D rb;
    private Vector2 moveDir;
    private Knockback knockback;
    private SpriteRenderer spriteRenderer;
    private Transform playerTransform;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        knockback = GetComponent<Knockback>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        playerTransform = PlayerController.Instance.transform;
    }

    private void FixedUpdate()
    {
        if (knockback.GettingKnockedBack) { return; }

        if (Vector2.Distance(transform.position, playerTransform.position) <= detectionRange)
        {
            MoveTo(playerTransform.position);
        }
        else
        {
            StopMoving();
        }

        rb.MovePosition(rb.position + moveDir * (moveSpeed * Time.fixedDeltaTime));

        if (moveDir.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    public void MoveTo(Vector2 targetPosition)
    {
        Vector2 direction = targetPosition - rb.position;
        moveDir = direction.normalized;
    }

    public void StopMoving()
    {
        moveDir = Vector3.zero;
    }
}
