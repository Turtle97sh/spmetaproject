using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 minBounds;
    public Vector2 maxBounds;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        // �Է� �޾Ƽ� �̵� ���� ���
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed;

        // ���� ��ġ���� �̵� ���
        Vector2 newPosition = rb.position + movement * Time.fixedDeltaTime;

        // ���� ����
        float clampedX = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);

        // ���� �̵�
        rb.MovePosition(new Vector2(clampedX, clampedY));

        // �ִϸ��̼� �Ķ���� ���� (����)
        bool isMoving = moveX != 0 || moveY != 0;
        animator.SetBool("isMoving", isMoving);
    }
}
