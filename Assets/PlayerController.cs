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
        // 입력 받아서 이동 벡터 계산
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed;

        // 현재 위치에서 이동 계산
        Vector2 newPosition = rb.position + movement * Time.fixedDeltaTime;

        // 범위 제한
        float clampedX = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);

        // 실제 이동
        rb.MovePosition(new Vector2(clampedX, clampedY));

        // 애니메이션 파라미터 설정 (예시)
        bool isMoving = moveX != 0 || moveY != 0;
        animator.SetBool("isMoving", isMoving);
    }
}
